using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

    public class ExitManager : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("IPointerTest OnClick");
        }
    }

