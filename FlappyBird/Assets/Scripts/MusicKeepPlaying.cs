using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicKeepPlaying : MonoBehaviour
{
    private static MusicKeepPlaying backgroundMusic;

    //Script for music so it can play over scenes
    void Awake()
    {
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
