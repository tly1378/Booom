using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource audio;
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
            audio.Pause();
        }
        else
        {
            liuyin.SetBool("on", true);
            audio.Play();
        }
    }
    public static void turnOnOff()
    {
        if (Music.turn == 0)
        {
            //liuyin.SetBool("on", true);
            Music.turn = 1;
            Debug.Log("1");
        }
        else
        {
            Music.turn = 0;
            Debug.Log("2");
        }


    }
}
