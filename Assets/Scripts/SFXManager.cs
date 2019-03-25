using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance = null;

    public GameObject coinParticles;

    void Awake (){
        if (instance == null){
            instance = this;
        }
    }

    public void ShowCoinParticles(GameObject obj){
        GameObject particles = Instantiate(coinParticles, obj.transform.position, Quaternion.identity);
        GameObject parent = GameObject.Find("Tape");
        particles.transform.SetParent(parent.transform);
    }
}
