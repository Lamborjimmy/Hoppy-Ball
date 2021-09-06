using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    
   
    //Game over buttons functions
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //GameObject.Find("PauseButton").SetActive(true);
    }
    
    
}
