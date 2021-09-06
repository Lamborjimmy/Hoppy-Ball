using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SettingsMenu : MonoBehaviour
{
    //Assing value of slider to a mixer so it will change the volume
    public AudioMixer audioMixerMusic;
    public AudioMixer audioMixerSfx;
    public void SetVolumeMusic(float volume)
    {
        audioMixerMusic.SetFloat("volume", volume);
    }
    
    public void SetVolumeSFX(float volume)
    {
        audioMixerSfx.SetFloat("volume", volume);
    }
}
