using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawing : MonoBehaviour
{
    public Collider drawC;
    public GameObject text;
    //public GameObject text1;
    private int yes = 0;
    private void OnTriggerEnter(Collider drawC)
    {
        if (yes == 0)
        {

            text.SetActive(true);
            Invoke("Delay", 3f);
            //Invoke("Delay", 6f);
            yes = 1;
        }
    }
    void Delay()
    {
        text.SetActive(false);
       // text1.SetActive(true);
    }
    //void Delay1()
    //{
     //   text1.SetActive(false);
   // }
}
