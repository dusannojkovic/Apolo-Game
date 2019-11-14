using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {

    private AudioSource source;
    private float musicVolume = 1f;
    // Use this for initialization

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        source.volume = musicVolume;
    }
    public void SetVolume(float volume)
    {
        musicVolume = volume;
    }
}
