using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlanController : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject clickedobject = eventData.pointerCurrentRaycast.gameObject;

        if (clickedobject.tag == "stickyNote")
        {
            clickedobject.SetActive(false);
        }

        else if (clickedobject.tag == "planBtn")
        {
        }
    }
}
