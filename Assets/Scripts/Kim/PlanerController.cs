using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlanerController : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private StickyNote[] stickyNotes;
    [SerializeField] private Sprite[] noteSprites;
    [SerializeField] private Text totalMoneyText;
    [SerializeField] private Button selectButton;
    [SerializeField] private GameObject HomeCanvas;

    private int totalMoney;
    private int count;

    public string[] Notes;
    public GameObject canvasManager;

    public void Start()
    {
        canvasManager = GameObject.Find("CanvasManager");
    }

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
                    totalMoneyText.text = totalMoney + "¿ø";
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
                totalMoneyText.text = totalMoney + "¿ø";
                return;
            }
        }
    }


    public void SelectButton()
    {
        count = 0;
        for(int i = 0; i < stickyNotes.Length; i++)
        {
            if (stickyNotes[i].gameObject.activeSelf == true)
                count++;
        }

        if(DataManager.Instance.gameData.gold >= totalMoney && count == stickyNotes.Length)
        {
            Notes = new string[stickyNotes.Length];
            for(int i = 0; i < stickyNotes.Length; i++)
            {
                Notes[i] = stickyNotes[i].name;
            }
            DataManager.Instance.gameData.gold -= totalMoney;
            //HomeCanvas.SetActive(false);
            //BehaviorCanvas.SetActive(true);
            canvasManager.GetComponent<CanvasManager>().BehaviorCanvasOnOff(true);
            canvasManager.GetComponent<CanvasManager>().AnimatorOnOff(true);
        }
    }

    public void ResetPlan()
    {
        for(int i = 0; i < stickyNotes.Length; i++)
        {
            stickyNotes[i].gameObject.SetActive(false);
            stickyNotes[i].name = "StickyNote";
            totalMoney = 0;
            totalMoneyText.text = "¿ø";
        }
    }
}