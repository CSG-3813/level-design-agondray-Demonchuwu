using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VoiumeManager : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider MusicSlider;
    public Slider MasterSlider;
    public Slider SFXSlider;
    void Start()
    {
        MasterSlider.value = PlayerPrefs.GetFloat("MasterVolume", 0.75f);
        MusicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume", 0.75f);
    }
    public void SetMaster()
    {
        float sliderValue = MasterSlider.value;
        mixer.SetFloat("MasterVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MasterVolume", sliderValue);

    }

    public void SetMusic()
    {
        float sliderValue = MusicSlider.value;
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
    public void SetSFX()
    {
        float sliderValue = SFXSlider.value;
        mixer.SetFloat("SFXVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFXVolume", sliderValue);
    }

}
