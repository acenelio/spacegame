using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Coin")){
            AudioManager.instance.PlayCoinPickupSound(other.gameObject);
            SFXManager.instance.ShowCoinParticles(other.gameObject);
            Destroy(other.gameObject);
            LevelManager.instance.IncrementCoinCount();
        }
        if (other.gameObject.CompareTag("Gift")){
            StopMusicAndTape();
            AudioManager.instance.PlayLevelCompleteSound(gameObject);
            Destroy(other.gameObject);
            LevelManager.instance.ShowLevelCompletePanel();
        }
        else if (other.gameObject.layer==LayerMask.NameToLayer("Enemies")){
            KillPlayer();
        }
        else if (other.gameObject.layer==LayerMask.NameToLayer("Forbiden")){
            KillPlayer();
    }
}

    void StopMusicAndTape(){
        Camera.main.GetComponentInChildren<AudioSource>().mute = true;
        LevelManager.instance.SetTapeSpeed(0);
    }
    void KillPlayer (){
        StopMusicAndTape();
        AudioManager.instance.PlayFailSound(gameObject);
        SFXManager.instance.ShowDieParticles(gameObject);
        Destroy(gameObject);
    }
}