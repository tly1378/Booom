using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen2 : MonoBehaviour
{
    public static int open = 0,open1 = 0 ;
    public Animator door;
    public GameObject text1;
    // Update is called once per frame
    void Update()
    {
        if (open == 1)
        {
            door.SetBool("open", true);
            open = 2;
        }
        if (open1 == 1)
        {
            door.SetBool("open2", true);
            open1 = 2;
        }

    }
    public static void doorO2()
    {
        open = 1;

    }
    public static void doorO3()
    {
        open1 = 1;

    }
    public void text()
    {
        text1.SetActive(true);
        Invoke("Delay", 2f);
    }
    void Delay()
    {
        text1.SetActive(false);
    }
}
