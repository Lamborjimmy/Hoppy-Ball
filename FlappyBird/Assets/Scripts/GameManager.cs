using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 10f;
    public GameObject completeLevel;
    public GameObject ground;
    public int coinValue = 0;
    public GameObject roof;

    //Script for what will happen if player completes level
    public void CompleteLevel()
    {
        
        completeLevel.SetActive(true);
        ground.GetComponent<BoxCollider>().enabled = false;
        roof.GetComponent<BoxCollider>().enabled = false;
        //Disabling colliders so player can't die once he finishes the level 
    }
    //Script for what will happen if player die
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    //Restarting the game...
    private void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
   
}
