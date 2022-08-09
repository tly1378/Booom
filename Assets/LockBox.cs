using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBox : MonoBehaviour
{
    public GameObject cipher1,cipher2,cipher3,cipher4;
    public GameObject ui1, ui2, ui3, ui4,key;
    public static int one,two,three,four;
    public static int count=0;
    private int m = 0,n=0;
    public Animator lockB;

    private void Update()
    {
       if(count>m)
        {
            AudioManager.S.PlayStageSfx(3);
        }
        //cipher1.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -36f*one));
        //cipher2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -36f * two));
        //cipher3.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -36f * three));
        //cipher4.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -36f * four));
        cipher1.transform.localEulerAngles = new Vector3(0, 0, 36f * one);
        cipher2.transform.localEulerAngles = new Vector3(0, 0, 36f * two);
        cipher3.transform.localEulerAngles = new Vector3(0, 0, 36f * three);
        cipher4.transform.localEulerAngles = new Vector3(0, 0, 36f * four);
        m = count;
        if(one == 5 && two == 2 && three == 3 && four == 3 && n==0)
        {
            lockB.SetBool("open", true);
            AudioManager.S.PlayStageSfx(4);
            ui1.SetActive(false);
            ui2.SetActive(false);
            ui3.SetActive(false);
            ui4.SetActive(false);
            key.SetActive(true);
            n = 1;
        }
    }
  
    public static void cipherOne()
    {
        one += 1;
        count += 1;
        if(one >9)
        {
            one = 0;
        }
    }
    public static void cipherTwo()
    {
        two += 1;
        count += 1;
        if (two > 9)
        {
           two = 0;
        }
    }
    public static void cipherThree()
    {
        three += 1;
        count += 1;
        if (three > 9)
        {
            three = 0;
        }
    }
    public static void cipherFour()
    {
        four += 1;
        count += 1;
        if (four > 9)
        {
            four = 0;
        }
    }
}
