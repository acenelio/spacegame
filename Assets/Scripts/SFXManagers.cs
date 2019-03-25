using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManagers : MonoBehaviour
{
    public static SFXManagers instance;

    public GameObject coinParticles;

    void Awake (){
        if (instance == null){
            instance = this;
        }
    }

    public void ShowCoinParticles(GameObject obj){
        Instantiate(coinParticles, obj.transform.position, Quaternion.identity);
    }
}
