using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMute : MonoBehaviour
{
    public static AudioMute instance;

    public bool AudioOn = true;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SwitchAudio()
    {
        AudioOn = !AudioOn;

        GameObject bgMusic = GameObject.Find("BGMusic");
        if (bgMusic != null)
        {
            AudioSource audioSource = bgMusic.GetComponent<AudioSource>();
            audioSource.mute = !AudioOn;
        }
    }

    public void TurnOffAudio()
    {
        AudioOn = false;

        GameObject bgMusic = GameObject.Find("BGMusic");
        if (bgMusic != null)
        {
            AudioSource audioSource = bgMusic.GetComponent<AudioSource>();
            audioSource.mute = true;
        }
    }

    public void TurnOnAudio()
    {
        AudioOn = true;

        GameObject bgMusic = GameObject.Find("BGMusic");
        if (bgMusic != null)
        {
            AudioSource audioSource = bgMusic.GetComponent<AudioSource>();
            audioSource.mute = false;
        }
    }
}
