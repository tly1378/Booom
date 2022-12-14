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
    private Transform ui_e;
    public Transform ui_e_sample;
    public static InteractableItem target;
    void Start()
    {
        ui_e = Instantiate(ui_e_sample, GameObject.Find("Canvas").transform);
        ui_e.gameObject.SetActive(false);
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
        index+=1;
        if (Camera.main == null) return;

        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        ui_e.position = screenPos;
        if (screenPos.z < 0)
            return;

        float current_distance = ((Vector2)screenPos - center).sqrMagnitude;
        if((transform.position - Camera.main.transform.position).sqrMagnitude < 36)
        {
            if (distance > current_distance || next == null)
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
            print(name);
        }
        catch(TypeLoadException)
        {
            Debug.LogError("??????????????????class");
        }
        catch (MissingMethodException)
        {
            Debug.LogError("??????????????????method");
        }
    }

    private void SwitchUI(InteractableItem old_item, InteractableItem new_item)
    {
        //print($"???????????????{(old_item == null?"(???)": old_item)}?????????{(new_item == null ? "(???)" : new_item)}???");
        if (old_item != null)
        {
            old_item.ui_e.gameObject.SetActive(false);
        }
        if (new_item != null)
        {
            new_item.ui_e.gameObject.SetActive(true);
            print("new");
        }
    }

    public static void Test()
    {
        print(target.transform.parent.name);
    }
}
