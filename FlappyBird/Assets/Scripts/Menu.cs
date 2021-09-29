using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private int sceneToContinue;
    private int hasPlayed;



    //Menu functions

    private void Start()
    {
        hasPlayed = PlayerPrefs.GetInt("hasPlayed", 0);
        sceneToContinue = PlayerPrefs.GetInt("savedScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
    
    public void StartGame() 
    {
        if (hasPlayed == 0)
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("hasPlayed", 1);

        }
        else {
            
            SceneManager.LoadScene(sceneToContinue);
        }

        
     
    }
    
    
}
