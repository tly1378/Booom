using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telephone : MonoBehaviour
{
    public GameObject text;
    private static int yes = 0;
    void Update()
    {
        if (yes == 1)
        {
            AudioManager.S.PlayStageSfx(5);
            text.SetActive(true);
            Invoke("Delay", 2f);
            yes = 0;
        }
    }
    public static void phone()
    {
        yes = 1;
    }
    void Delay()
    {
        text.SetActive(false);
    }
}
