using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform finishLine;
    [SerializeField] Slider slider;
    float maxDistance;
    

    //Script for level progress bar 
    void Start()
    {
        
        maxDistance = getDistance();
    }

    void Update()
    {
        if(finishLine.position.x <= maxDistance && finishLine.position.x >= player.position.x)
        {
            float distance = 1 - (getDistance() / maxDistance);
            setProgress(distance);
        }
    }
    float getDistance()
    {
        return Vector3.Distance(player.position, finishLine.position);
    }
    void setProgress(float p )
    {
        slider.value = p;
    }

    
}
