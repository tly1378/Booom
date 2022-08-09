using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen1 : MonoBehaviour
{
    public static int open = 0 ;
    public Animator door;
    // Update is called once per frame
    void Update()
    {
        if(open == 1 )
        {
            door.SetBool("open", true);
            open = 2;
        }
    }
    public static void doorO()
    {
        open = 1 ;

    }
}
