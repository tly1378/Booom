using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide1 : MonoBehaviour
{
    public Collider guideC;
    public GameObject text;
    //public GameObject text1;
    private int yes = 0;
    private void OnTriggerEnter(Collider guideC)
    {
        if (yes == 0)
        {

            text.SetActive(true);
            Invoke("Delay", 3f);
            //Invoke("Delay1", 6f);
            yes = 1;
        }
    }
    void Delay()
    {
        text.SetActive(false);
     //   text1.SetActive(true);
    }
    //void Delay1()
    //{
     //   text1.SetActive(false);
   // }
}
