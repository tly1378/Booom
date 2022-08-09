using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typewritter : MonoBehaviour
{
    public GameObject text;
    private static int typeyes = 0;
    void Update()
    {
        if (typeyes == 1)
        {
            AudioManager.S.PlayStageSfx(5);
            text.SetActive(true);
            Invoke("Delay", 2f);
            typeyes = 0;
        }
    }
    public static void type()
    {
        typeyes = 1;
    }
    void Delay()
    {
        text.SetActive(false);
    }
}
