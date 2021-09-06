using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody rb;
    public float forwardForce = 200;
    public GameObject obstacle;
    
    //Obstacles movement and also destroy so it won't be lagging
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Destroy()
    {
        if(gameObject.transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
    }

}
