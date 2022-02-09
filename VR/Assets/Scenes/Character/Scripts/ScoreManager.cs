using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    int score;
  TMP_Text scoreText;
  


    // Start is called before the first frame update

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "0";

      
    }
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease; // = score = score + amountToIncrease;
        scoreText.text = score.ToString();


    }
}
