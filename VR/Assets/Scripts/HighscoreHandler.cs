using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreHandler : MonoBehaviour
{
    /* [SerializeField] HighscoreUI highscoreUI;
    int highscore;

    public int Highscore
    {
        set
        {
            highscore = value;
            //highscoreUI.SetHighscore(value);
        }
    }
    void Start()
    {
        SetLatestHighcore();
    }

   private void SetLatestHighcore()
    {
        Highscore = PlayerPrefs.GetInt("Highscore", 0);
    }

    private void SaveHighscore (int score)
    {
        PlayerPrefs.SetInt("Highscore", score);
    }

    //this method will be called every time the game ends and will see if there's a new highscore

    public void SetHighscoreIfGreater (int score)
    {
        if (score > highscore)
        {
            Highscore = score;
            SaveHighscore(score);
            
        }
    } */

    List<HighscoreElements> highscoreList = new List<HighscoreElements>();
    [SerializeField] int maxCount = 6;
    [SerializeField] string filename;
    

    public delegate void OnHighscoreListChanged(List<HighscoreElements> list);
    public static event OnHighscoreListChanged onHighscoreListChanged;

    private void Start()
    {
        LoadHighScores();
    }

    private void LoadHighScores()
    {
        highscoreList = FileHandler.ReadListFromJSON<HighscoreElements>(filename);

        while (highscoreList.Count > maxCount)
        {
            highscoreList.RemoveAt(maxCount);
        }

        //load the "celebration" event because of new highscore

        if(onHighscoreListChanged != null)
        {
            onHighscoreListChanged.Invoke(highscoreList);
        } 

    }

    private void SaveHighScores()
    {
        FileHandler.SaveToJSON<HighscoreElements>(highscoreList, filename);
    }

    public void AddHighScoreIfPossible(HighscoreElements element)
    {
        for (int i = 0; i < maxCount; i++)
        {
            if (i >= highscoreList.Count || element.points > highscoreList[i].points)
            {
                //add new high score
                highscoreList.Insert(i, element);

                while (highscoreList.Count > maxCount)
                {
                    highscoreList.RemoveAt(maxCount);
                }

                SaveHighScores();

                //load the "celebration" again

                if (onHighscoreListChanged != null)
                {
                    onHighscoreListChanged.Invoke(highscoreList);
                } 

                break; //break will skip the rest of the for loop if the entries are less than the max count
            }
          
        }
    }
}
