using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.AsteroidDestroyed += DisplayScore;
    }

    private void OnDisable()
    {
        GameManager.AsteroidDestroyed -= DisplayScore;
    }

    public void DisplayScore()
    {
        // Debug.Log(GameManager.playerScore);
        GetComponent<TextMeshProUGUI>().text = "Score: " + GameManager.playerScore.ToString();
    }
}
