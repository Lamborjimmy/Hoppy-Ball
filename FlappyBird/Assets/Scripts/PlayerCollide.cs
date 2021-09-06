using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class PlayerCollide : MonoBehaviour
{
    public AudioSource obstacleHit;
    public GameObject gameOver;
    public AudioSource coinCollect;
    public PlayerMovement moves;
    public GameObject deathEffect;
    public GameObject coinCollector;
    public GameObject player;
    public int currentSceneIndex;
    

    public void OnCollisionEnter(Collision collision)
    {
        //Script for what will happends if player dies.
        if (collision.collider.tag == "Obstacle" || collision.collider.tag == "Ground")
        {
            GameObject.Find("Canvas").GetComponent<ScoreManager>().ResetScore();
            GameObject finish = GameObject.Find("FinishLine");
            FinishMove finishMove = finish.GetComponent<FinishMove>();
            finishMove.forwardForce = -100;
            
            Destroy();
            
            GameObject.Find("PauseButton").SetActive(false);
            Handheld.Vibrate();
            
            gameOver.SetActive(true);
            
            obstacleHit.Play();
            
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("savedScene", currentSceneIndex);

            FindObjectOfType<GameManager>().EndGame();

            TextMeshProUGUI scoreDeathText = GameObject.Find("ScoreDeath").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI highscoreDeathText = GameObject.Find("HighscoreDeath").GetComponent<TextMeshProUGUI>();

            TextMeshProUGUI scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI highscoreText = GameObject.Find("Highscore").GetComponent<TextMeshProUGUI>();

            scoreText.text = " ";
            highscoreText.text = " ";

            




        }

    }

    //Script for collecting
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 10)
        {
            ScoreManager.instance.AddScore();
            Collect();
            Destroy(collision.gameObject);
            coinCollect.Play();
        }
    }

    //Particles after player death
    public void Destroy()
    {
        GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        effect.GetComponent<ParticleSystem>().Play();
        player.SetActive(false);
    }
    //Particles on collecting score
    public void Collect()
    {
        GameObject effect = Instantiate(coinCollector, transform.position, Quaternion.identity);
        effect.GetComponent<ParticleSystem>().Play();
    }

    
   

   

}
