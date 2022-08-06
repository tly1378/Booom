using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class begin : MonoBehaviour
{
    public GameObject slot1;
    public GameObject camera0;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void beginSlot()
    {
        slot1.SetActive(true);
        
    }
    public void cameraOff()
    {
        camera0.SetActive(false);

    }
}
