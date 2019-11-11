using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSFX audioSFX;
    public AudioPlayer audioPlayer;

    void Awake(){
        if (instance == null){
            instance = this;
        }
    }

    public void PlayCoinPickupSound(GameObject obj){
        TocarSom(audioSFX.coinPickup, obj.transform.position);
    }
    public void PlayJumpPickupSound(GameObject obj){
        TocarSom(audioSFX.coinPickup, obj.transform.position);
    }
    public void PlayFailSound(GameObject obj){
        TocarSom(audioSFX.fail, obj.transform.position);
    }
    public void PlayLevelCompleteSound(GameObject obj){
        TocarSom(audioSFX.levelComplete, obj.transform.position);
    }

    void TocarSom(AudioClip audioClip, Vector3 position)
    {
        if (AudioMute.instance.AudioOn)
        {
            AudioSource.PlayClipAtPoint(audioClip, position);
        }
    }
}
