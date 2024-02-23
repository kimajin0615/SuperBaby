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
    [SerializeField] private Text totalMoneyText;

    private int totalMoney;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject clickedobject = eventData.pointerCurrentRaycast.gameObject;

        if (clickedobject.tag == "stickyNote")
        {
            clickedobject.SetActive(false);

            Behavior[] m_behaviors = Resources.LoadAll<Behavior>("ScriptableObject/Behavior");
            foreach (Behavior behavior in m_behaviors)
            {
                if (behavior.englishName == clickedobject.name)
                {
                    totalMoney -= behavior.cost;
                    totalMoneyText.text = totalMoney + "원";
                    clickedobject.name = "StickyNote";
                }
            }
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
                stickyNotes[index].name = behavior.englishName;
                totalMoney += behavior.cost;
                totalMoneyText.text = totalMoney + "원";
                return;
            }
        }
    }

    public void SelectButton()
    {
        if(DataManager.Instance.gameData.gold >= totalMoney)
        {
            DataManager.Instance.gameData.gold -= totalMoney;
            // 애니메이션 화면으로
        }
    }

    public void ResetPlan()
    {
        for(int i = 0; i < stickyNotes.Length; i++)
        {
            stickyNotes[i].gameObject.SetActive(false);
            stickyNotes[i].name = "StickyNote";
            totalMoney = 0;
            totalMoneyText.text = "원";
        }
    }
}