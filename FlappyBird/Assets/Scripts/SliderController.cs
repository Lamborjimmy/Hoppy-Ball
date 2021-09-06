using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{

    //Saving the slider value, so the music won't reset at the start of the game
    public Slider sliderMusic;
    public Slider sliderSFX;

    public float sliderValueMusic;
    public float sliderValueSFX;
    public void Start()
    {

        sliderMusic.value = PlayerPrefs.GetFloat("musicSave", sliderValueMusic);
        sliderSFX.value = PlayerPrefs.GetFloat("sfxSave", sliderValueSFX);
    }
    public void ChangeSliderMusic(float value)
    {
        sliderValueMusic = value;
        PlayerPrefs.SetFloat("musicSave", sliderValueMusic);
    }
    public void ChangeSliderSFX(float value)
    {
        sliderValueSFX = value;
        PlayerPrefs.SetFloat("sfxSave", sliderValueSFX);
    }
    
}
