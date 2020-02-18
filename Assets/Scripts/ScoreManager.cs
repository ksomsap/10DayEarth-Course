using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    static public int scoreValue = 0;

    private void Start()
    {
        scoreValue = 0;
        highscoreText.text = "TOP : " + PlayerPrefs.GetInt("HighScore",0).ToString();
    }
    void Update()
    {
        scoreText.text = "Score : " + scoreValue.ToString();

        if(scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreValue);
        }
    }
}
