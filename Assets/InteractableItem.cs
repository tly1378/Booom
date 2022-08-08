using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    static float distance;
    static Vector2 center;
    static int count;
    static int index;
    static Vector2 position;
    static Transform ui;
    static TMPro.TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        count++;
        if (center == default)
        {
            center = new Vector2(Screen.width / 2, Screen.height / 2);
            ui = GameObject.Find("Canvas/E").transform;
            text = ui.GetComponent<TMPro.TMP_Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        index++;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.z < 0) return;
        float current_distance = ((Vector2)screenPos - center).sqrMagnitude;
        print(distance+" "+ current_distance +" "+ (distance > current_distance));
        if (distance > current_distance || index == 1)
        {
            distance = current_distance;
            position = screenPos;
        }
        if (index >= count)
        {
            index = 0;
            ui.position = position;
            //text.text = distance.ToString();
        }
    }
}
