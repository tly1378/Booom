using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sculpture : MonoBehaviour
{
    public GameObject text;
    public static int yes = 0;
    private void Update()
    {
        if(yes==1)
        {
            text.SetActive(true);
            Invoke("Delay", 3f);
          //  Invoke("Delay1", 6f);
            yes = 0;
        }
    }
    public static void sulp()
    {
        yes = 1;
    }
    void Delay()
    {
        text.SetActive(false);
        //text1.SetActive(true);
    }
    //void Delay1()
    //{
       // text1.SetActive(false);
    //}
}
