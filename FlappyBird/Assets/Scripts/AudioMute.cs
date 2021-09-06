using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMute : MonoBehaviour
{
    [SerializeField] Image soundOn;
    [SerializeField] Image soundOff;

    private bool muted = false;
    void Start()
    {
        //Script to keep the audio mute button muted
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }
    public void OnButtonPress()
    {
        //Script to mute the audio
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
        
    }
    private void UpdateButtonIcon()
    {
        //Change the image to sound on and off
        if(muted == false)
        {
            soundOn.enabled = true;
            soundOff.enabled = false;

        }
        else
        {
            soundOff.enabled = true;
            soundOn.enabled = false;
        }
    }
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;  
    }
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

    
}
