using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class LevelComplete : MonoBehaviour
{
    public static LevelComplete instance;
    private int sceneToContinue;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    
    //This line of code is for loading next levels and I wanted to restart the game while the player reaches 500lvl and finish it 
    public void LoadNextLevel()
    {
        sceneToContinue = PlayerPrefs.GetInt("savedScene");
        if (SceneManager.GetActiveScene().buildIndex != 500)
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Level1");
        }
    }
}

