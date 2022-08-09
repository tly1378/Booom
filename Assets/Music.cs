using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private static AudioSource audio;
    private static int turn = 0;
    public AudioClip liuyinji;
    public Animator liuyin;
    void Start()
    {

        audio = transform.GetComponent<AudioSource>();
        audio.clip = liuyinji;

    }
    private void Update()
    {
        if(turn == 0)
        {
            liuyin.SetBool("on", false);
            
        }
        else
        {
            liuyin.SetBool("on", true);
            
        }
    }
    public static void turnOnOff()
    {
        if (Music.turn == 0)
        {
            //liuyin.SetBool("on", true);
            Music.turn = 1;
            Music.audio.Play();
            Debug.Log("1");
        }
        else
        {
            Music.turn = 0;
            Music.audio.Pause();
            Debug.Log("2");
        }


    }
}
