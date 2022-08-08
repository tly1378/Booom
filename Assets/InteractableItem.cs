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
    static Vector2 position;
    public Transform ui_e;
    public static InteractableItem target;
    void Start()
    {
        count++;
        if (center == default)
        {
            center = new Vector2(Screen.width / 2, Screen.height / 2);
            //text = ui.GetComponent<TMPro.TMP_Text>();
        }
    }

    static int index;
    static InteractableItem next;
    void Update()
    {
        if (target != this) 
            ui_e.gameObject.SetActive(false);
        else
            ui_e.gameObject.SetActive(true);

        index++;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        ui_e.position = screenPos;
        if (screenPos.z < 0)
            return;

        float current_distance = ((Vector2)screenPos - center).sqrMagnitude;
        if((transform.position - Camera.main.transform.position).sqrMagnitude < 25)
        {
            if (distance > current_distance || index == 1)
            {
                distance = current_distance;
                position = screenPos;
                next = this;
            }
        }

        if (index >= count)
        {
            if(next == null)
            {
                target = null;
            }
            else if (next != target)
            {
                SwitchUI(target != null ? target.gameObject : null, next != null ? next.gameObject : null);
                target = next;
            }

            index = 0;
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

    private void SwitchUI(GameObject old_e, GameObject new_e)
    {
        //注意，old_e有可能为null。
        print($"交互按钮由{(old_e==null?"空":old_e)}切换至{new_e}。");
    }

    public static void Test()
    {
        print(target.transform.parent.name);
    }
}
