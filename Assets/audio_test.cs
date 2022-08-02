using UnityEngine;
using System.Collections;

public class audio_test : MonoBehaviour
{

    public AudioSource s;
    // Use this for initialization
    void Start()
    {
        // 声音的全局设置
        AudioConfiguration audio_config = AudioSettings.GetConfiguration();
        //....中间设置内容
        AudioSettings.Reset(audio_config);//设置完后再放回去
                                          // end 
        //this.s.PlayDelayed(5);//延迟5秒播放
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {//鼠标左键按下
            if (this.s.isPlaying)
            {
                this.s.Pause();
            }
            else
            {
                this.s.Play();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {//鼠标右键按下
            this.s.Stop();
        }
    }
}