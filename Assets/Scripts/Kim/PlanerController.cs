using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlanerController : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private StickyNote[] stickyNotes;
    [SerializeField] private Sprite[] noteSprites;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject clickedobject = eventData.pointerCurrentRaycast.gameObject;

        if (clickedobject.tag == "stickyNote")
        {
            clickedobject.SetActive(false);
        }
    }

    public void PlanButton()
    {
        GameObject clickedobject = EventSystem.current.currentSelectedGameObject;
        int index;

        for (index = 0; index < stickyNotes.Length; index++) { if (stickyNotes[index].gameObject.activeSelf == false) break; }
        if (index == stickyNotes.Length) return;
        Behavior[] m_behaviors = Resources.LoadAll<Behavior>("ScriptableObject/Behavior");

        foreach (Behavior behavior in m_behaviors)
        {
            if (behavior.englishName == clickedobject.name)
            {
                stickyNotes[index].SetStickyNote(noteSprites[behavior.type], behavior.name);
                stickyNotes[index].gameObject.SetActive(true);
                return;
            }
        }
    }
}