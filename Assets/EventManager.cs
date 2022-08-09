using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public AudioSource phonograph;
    public Animator phonograph_animator;
    private void Start()
    {
        if (phonograph != null && phonograph_animator != null)
        {
            _phonograph = phonograph;
            _phonograph_animator = phonograph_animator;
        }
    }

    static AudioSource _phonograph;
    static Animator _phonograph_animator;
    public static void Phonograph()
    {
        print(_phonograph.isPlaying);
        if (_phonograph.isPlaying)
        {
            _phonograph.Pause();
            _phonograph_animator.SetBool("on", false);
        }
        else
        {
            _phonograph.Play();
            _phonograph_animator.SetBool("on", true);
        }
    }
}
