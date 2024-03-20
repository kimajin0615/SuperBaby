using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicsource;
    public List<AudioSource> btnsource = new List<AudioSource>();
    public Slider masterslider;
    public Slider MusicSlider;
    public Slider SfxSlider;

    public int index;

    public void SetMusicVolume(float volume)
    {
        musicsource.volume = volume * MusicSlider.value;
    }

    public void SetButtonMusicVolume(float volume)
    {
        btnsource[index].volume = volume * SfxSlider.value;
    }

    public void SetMasterVolume(float volume)
    {
        musicsource.volume = volume * masterslider.value;
        btnsource[index].volume = volume * masterslider.value;
    }

    public void OnSfx()
    {
        btnsource[index].Play();
    }

}
