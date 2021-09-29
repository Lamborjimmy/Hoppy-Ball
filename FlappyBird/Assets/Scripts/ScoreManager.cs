using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI scoreDeathText;
    public TextMeshProUGUI highscoreDeathText;
    int score = 0;
    int highscore = 0;
    private void Awake()
    {
        instance = this;
    }
    //Player prefabs for score so when player passes the level it won't reset, and also player prefabs used for HIGHSCORE
    private void Start()
    {
        score = PlayerPrefs.GetInt("score", 0);
        highscore = PlayerPrefs.GetInt("highscore", 0); 
        scoreText.text = "Score:" + score.ToString();
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();
        scoreDeathText.text = "Score: " + score.ToString();
        highscoreDeathText.text = "HIGHSCORE: " + highscore.ToString();
        TinySauce.OnGameFinished(true, score);
    }
    public void AddScore()
    {
        score += 10;
        scoreText.text = "Score:" + score.ToString();
        scoreDeathText.text = "Score : " + score.ToString();
        PlayerPrefs.SetInt("score", score);
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
    //Reseting the score if player dies
    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("score");
    }    
    
}
