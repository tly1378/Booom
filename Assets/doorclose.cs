using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorclose : MonoBehaviour
{
    public Collider doorcC;
    public Animator door;
    public GameObject thisOne;
    public GameObject ui1;
    private void OnTriggerEnter(Collider doorcC)
    {
        door.SetBool("close", true);
        thisOne.SetActive(false);
        ui1.SetActive(false);
        //ui2.SetActive(true);
    }

}
