using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    static float distance;
    static Vector2 center;
    static int count;
    static int index;
    static Vector2 position;
    static Transform ui;
    public static InteractableItem target;

    void Start()
    {
        count++;
        if (center == default)
        {
            center = new Vector2(Screen.width / 2, Screen.height / 2);
            ui = GameObject.Find("Canvas/E").transform;
            //text = ui.GetComponent<TMPro.TMP_Text>();
        }
    }

    void Update()
    {
        index++;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.z < 0) return;
        float current_distance = ((Vector2)screenPos - center).sqrMagnitude;
        if (distance > current_distance || index == 1)
        {
            distance = current_distance;
            position = screenPos;
            target = this;
        }
        if (index >= count)
        {
            index = 0;
            //print((transform.position - Camera.main.transform.position).magnitude);
            if ((transform.position - Camera.main.transform.position).magnitude > 5)
            {
                ui.gameObject.SetActive(false);
                target = null;
            }
            else
            {
                ui.position = position;
                ui.gameObject.SetActive(true);
            }
        }
    }

    public string className;
    public string staticMethodName;
    public void Interact()
    {
        try
        {
            Type t = Type.GetType(className, true, true);
            t.InvokeMember(staticMethodName,
                    BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public, null, null, new object[] { });
        }
        catch(TypeLoadException)
        {
            //找不到指定的class
        }
        catch (MissingMethodException)
        {
            //找不到指定的method
        }
    }

    public static void Test()
    {
        print("Test");
    }
}
