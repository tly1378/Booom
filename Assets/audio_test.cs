using UnityEngine;
using System.Collections;

public class audio_test : MonoBehaviour
{

    public AudioSource s;
    // Use this for initialization
    void Start()
    {
        // ������ȫ������
        AudioConfiguration audio_config = AudioSettings.GetConfiguration();
        //....�м���������
        AudioSettings.Reset(audio_config);//��������ٷŻ�ȥ
                                          // end 
        //this.s.PlayDelayed(5);//�ӳ�5�벥��
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {//����������
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
        {//����Ҽ�����
            this.s.Stop();
        }
    }
}