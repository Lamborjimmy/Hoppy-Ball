using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    private int currentSceneIndex;
    
    //Pause menu and button functions
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        
        
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        
    }

    public void Home()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("savedScene", currentSceneIndex);
        
        GameObject.Find("Canvas").GetComponent<ScoreManager>().ResetScore();
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartingMenu");
    }
}
