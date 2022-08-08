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
        //if (target != this) 
        //    ui_e.gameObject.SetActive(false);
        //else
        //    ui_e.gameObject.SetActive(true);

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
            if(next != target)
            {
                SwitchUI(target, next);
            }
            target = next;
            index = 0;
            next = null;
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

    private void SwitchUI(InteractableItem old_item, InteractableItem new_item)
    {
        print($"交互按钮由{(old_item == null?"(空)": old_item)}切换至{(new_item == null ? "(空)" : new_item)}。");
        if (old_item != null)
        {
            old_item.ui_e.gameObject.SetActive(false);
        }
        if (new_item != null)
        {
            new_item.ui_e.gameObject.SetActive(true);
        }
    }

    public static void Test()
    {
        print(target.transform.parent.name);
    }
}
