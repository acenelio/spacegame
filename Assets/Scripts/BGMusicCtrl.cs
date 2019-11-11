using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicCtrl : MonoBehaviour
{

    public void SwitchAudio()
    {
        AudioMute.instance.SwitchAudio();
    }
}
