using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishMove : MonoBehaviour
{
    //Giving the finish line movement
    private Rigidbody rb;
    public float forwardForce = 50f;
    public GameObject finishLine;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
    }
}
