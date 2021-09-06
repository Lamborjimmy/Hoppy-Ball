using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private int sceneToContinue;
    

    //Menu functions
    
    public void Quit()
    {
        Application.Quit();
    }
    
    public void StartGame() 
    {
        if (GameObject.Find("Player").GetComponent<PlayerCollide>().currentSceneIndex == 0)
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        }

        sceneToContinue = PlayerPrefs.GetInt("savedScene");
        SceneManager.LoadScene(sceneToContinue);
     
    }
    
    
}
