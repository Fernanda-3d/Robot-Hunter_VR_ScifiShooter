using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class HighscoreUI : MonoBehaviour
{
    /*  [SerializeField] TextMeshProUGUI highscoreText;

     public void SetHighscore (int score)
      {
          highscoreText.text = score.ToString();
      } */

    [SerializeField] GameObject coins, life;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject highscoreUIPrefab; //Prefab created with name and points
    [SerializeField] Transform elementWrapper; //empty GO that all the entries will lign up on

    List<GameObject> uiElements = new List<GameObject>();

    private void OnEnable()
    {
        HighscoreHandler.onHighscoreListChanged += UpdateUI;
    }

    private void OnDisable()
    {
        HighscoreHandler.onHighscoreListChanged -= UpdateUI;
    } 

    private void Start()
    {
        ClosePanel();
    }

    public void ShowPanel()
    {
        panel.SetActive(true);
        coins.SetActive(false);
        life.SetActive(false);

    }

    private void ClosePanel()
    {
        panel.SetActive(false);
        coins.SetActive(true);
        life.SetActive(true);
    }

    //this method could have been called as public and triggered when the ui appears / but will leave private to use delegates 
    // and events 
    private void UpdateUI (List<HighscoreElements> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            HighscoreElements el = list[i];

            if (el.points > 0)
            {
                if (i >= uiElements.Count)
                {
                    //instantiate new entry
                    var inst = Instantiate(highscoreUIPrefab, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent(elementWrapper, false);

                    uiElements.Add(inst);
                }

                // write or overwrite name and points
                var texts = uiElements[i].GetComponentsInChildren<Text>();
                texts[0].text = el.playerName;
                texts[1].text = el.points.ToString();
            }
        }
    }
}
