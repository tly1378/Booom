using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public void PlayFootStep0()
    {
        AudioManager.S.PlayPlayerSfx(0);
    }
    public void PlayFootStep1()
    {
        AudioManager.S.PlayPlayerSfx(1);
    }
}
