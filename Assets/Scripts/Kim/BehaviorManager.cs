using UnityEngine;
using UnityEngine.UI;

public class BehaviorManager : MonoBehaviour
{
    public Text monthText;
    public Text dayText;
    public Animator animator;
    //public GameObject HomeCanvas;
    public GameObject canvasManager;

    private GameObject planerController;
    private int day = 1;
    private string animationName;

    private void Awake()
    {
        canvasManager = GameObject.Find("CanvasManager");
    }

    private void OnEnable()
    {
        planerController = GameObject.Find("Calendar"); // <-
        if (planerController == null) Debug.Log("planerController is Null");
        if (canvasManager == null) Debug.Log("canvasManager is Null");
        //HomeCanvas.SetActive(false);
        canvasManager.GetComponent<CanvasManager>().HomeCanvasOnOff(false);
        monthText.text = DataManager.Instance.gameData.month + "¿ù";
    }

    public void FinishAnimation()
    {
        if(day < 35)
        {
            dayText.text = day + "ÀÏ";
            if (day == 1)
            {
                //animationName = planerController.Notes[0];
                animationName = planerController.GetComponent<PlanerController>().Notes[0];
            }
            if (day == 7)
            {
                //animationName = planerController.Notes[1];
                animationName = planerController.GetComponent<PlanerController>().Notes[1];
            }
            else if (day == 14)
            {
                //animationName = planerController.Notes[2];
                animationName = planerController.GetComponent<PlanerController>().Notes[2];
            }
            else if (day == 21)
            {
                //animationName = planerController.Notes[3];
                animationName = planerController.GetComponent<PlanerController>().Notes[3];
            }
            else if (day == 28)
            {
                //animationName = planerController.Notes[4];
                animationName = planerController.GetComponent<PlanerController>().Notes[4];
            }
            Debug.Log($"{day} : {animationName}");
            animator.SetTrigger(animationName);
            animator.Play(animationName + "_S");
            day += 1;
        }
        else
        {
            Debug.Log("³¡");

        }
    }
}
