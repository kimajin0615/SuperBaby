using UnityEngine;
using UnityEngine.EventSystems;

public class HomeDialogueController : MonoBehaviour, IPointerClickHandler
{
    public GameObject dialogPopup;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.tag == "SuSu")
        {
            DialogueManager.Instance.RunDialog("Test");
        }
    }
}
