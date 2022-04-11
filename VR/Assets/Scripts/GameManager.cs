using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] HighscoreHandler highscoreHandler;
    [SerializeField] HighscoreUI showUI;
    [SerializeField] string playerName; //change after for the saved name from the Input Text    
     
     

    // monitors the state of the game - used to track 
    public enum GameState
    {
        Intro,
        Playing,
        GameOver
    }

    public static GameState eGameStatus;

    public delegate void AsteroidHandler();
    public static event AsteroidHandler AsteroidDestroyed;

    [Header("Game Events")]
    public UnityEvent onStartActivated;
    public UnityEvent onGameOver;
    public UnityEvent onGameReset;

    [Header("Time Slider Components")]
    public Image sliderImg;
    public float gameDuration;
    private float sliderCurrentFillAmount = 1f;

    public static int playerScore = 0;

    private void Start()
    {
        eGameStatus = GameState.Intro;
    }

    private void Update()
    {
        if (eGameStatus == GameState.Playing)
        {            
            sliderImg.fillAmount = (sliderCurrentFillAmount - (Time.deltaTime / gameDuration));

            sliderCurrentFillAmount = sliderImg.fillAmount;

          /*  if(sliderCurrentFillAmount <= 0)
            {
               GameOver();
            } */
        } 

        if (eGameStatus == GameState.Playing)
        {
            if(LifeController.health < 1)
            {
                GameOver();
            }
        }

    }

    private void GameOver()
    {

        eGameStatus = GameState.GameOver; //this will automatically stop the time and stop the points
        //highscoreHandler.SetHighscoreIfGreater(playerScore);
        highscoreHandler.AddHighScoreIfPossible(new HighscoreElements(playerName, playerScore));
        showUI.ShowPanel();        
        onGameOver.Invoke();
              

        Invoke("RestartGame", 8f);

        
    }

    public static void AsteroidHit()
    {
        if (eGameStatus == GameState.Playing)
        {
            playerScore += 100;
            AsteroidDestroyed();
        }
        else
        {
            Debug.Log("Not in Play mode!");
        }
    }

    public void StartGame()
    {
        eGameStatus = GameState.Playing;
        onStartActivated.Invoke();
    }

    public void RestartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        /* onGameReset.Invoke();

         sliderCurrentFillAmount = 1f;
         playerScore = 0; */


    }
}
