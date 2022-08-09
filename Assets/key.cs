using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject ke,ui1;
    public static int pick = 0 ;
    public Animator door;
    void Update()
    {
        if(pick == 1)
        {
            ke.SetActive(false);
            ui1.SetActive(true);
            door.SetBool("key", true);
            pick = 0;
        }
    }
    public static void pickUp()
    {
        pick = 1;
    }
}
