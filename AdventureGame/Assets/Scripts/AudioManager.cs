using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource effectSource;
    public AudioSource musicSource;

    public AudioClip effectClick;

    public Slider sliderMusic, sliderSFX;

    public static AudioManager instance;

    void Awake()
    {
        instance = this;
    }

    public void PlayEffect()
    {
        effectSource.PlayOneShot(effectClick);
    }

    public void PlaySong(AudioClip audioClip)
    {
        musicSource.clip = audioClip;
        musicSource.Play();

    }
    public void OnMusicVolumeUpdate()
    {
        musicSource.volume = sliderMusic.value;
    }

    public void OnSFXVolumeUpdate()
    {
        effectSource.volume = sliderSFX.value;
    }
}
