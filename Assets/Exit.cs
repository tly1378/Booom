using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject exit;
    public Animator exitt;
    private int one = 0,two =0 ;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& one ==0 &&two ==0)
        {
            exit.SetActive(true);
            one = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && one == 1 )
        {
            exitt.SetBool("end",true);
            one = 0;
        }
    }
   
}
