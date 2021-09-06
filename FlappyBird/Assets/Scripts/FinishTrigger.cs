using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public AudioSource levelComplete;
    public GameManager gameManager;
    public GameObject levelPass;
    
    //Making the Level Complete text appear
    public void OnTriggerEnter()
    {
        Confetti();
        levelComplete.Play();
        gameManager.CompleteLevel();
    }
    //Level pass effect
    public void Confetti()
    {
        transform.rotation *= Quaternion.Euler(-90f, 0, 0);
        GameObject effect = Instantiate(levelPass, transform.position, transform.rotation);
        effect.GetComponent<ParticleSystem>().Play();
    }
}
