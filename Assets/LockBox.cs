using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBox : MonoBehaviour
{
    public GameObject cipher1,cipher2,cipher3,cipher4;
    public static int one,two,three,four;

    private void Update()
    {
        //cipher1.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -36f*one));
        //cipher2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -36f * two));
        //cipher3.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -36f * three));
        //cipher4.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -36f * four));
        cipher1.transform.localEulerAngles = new Vector3(0, 0, 36f * one);
        cipher2.transform.localEulerAngles = new Vector3(0, 0, 36f * two);
        cipher3.transform.localEulerAngles = new Vector3(0, 0, 36f * three);
        cipher4.transform.localEulerAngles = new Vector3(0, 0, 36f * four);
    }

    public static void cipherOne()
    {
        one += 1;
        if(one >9)
        {
            one = 0;
        }
    }
    public static void cipherTwo()
    {
        two += 1;
        if (two > 9)
        {
           two = 0;
        }
    }
    public static void cipherThree()
    {
        three += 1;
        if (three > 9)
        {
            three = 0;
        }
    }
    public static void cipherFour()
    {
        four += 1;
        if (four > 9)
        {
            four = 0;
        }
    }
}
