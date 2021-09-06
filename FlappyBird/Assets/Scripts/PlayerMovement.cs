using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;
    public Rigidbody rb;
    public float jumpForce = 2.4f;
    private int currentSceneIndex = 0;
    public TextMeshProUGUI levelIndex;

    //Giving player jump force to move 
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelIndex.text = currentSceneIndex.ToString();
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            rb.velocity = new Vector3(0f, jumpForce, 0f);
        }
    }
}
