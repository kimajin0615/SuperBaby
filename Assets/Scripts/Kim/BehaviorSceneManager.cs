using UnityEngine;
using UnityEngine.UI;

public class BehaviorSceneManager : MonoBehaviour
{
    public Text monthText;
    public Text dayText;
    public Animator animator;

    private int day = 1;
    private string animationName;

    void Start()
    {
        monthText.text = DataManager.Instance.gameData.month + "¿ù";
        //animator.Play("Test");
    }

    public void FinishAnimation()
    {
        if(day < 35)
        {
            dayText.text = day + "ÀÏ";
            if (day == 1)
            {
                Debug.Log($"{animationName}");
                Debug.Log($"{PlanerController.Notes[0]}");
                animationName = PlanerController.Notes[0] + "_S";
                Debug.Log($"{animationName}");
            }
            if (day == 7)
            {
                //animator.SetBool("TestBool",true);
                animationName = PlanerController.Notes[1] + "_S";
            }
            else if (day == 14)
            {
                animationName = PlanerController.Notes[2] + "_S";
            }
            else if (day == 21)
            {
                animationName = PlanerController.Notes[3] + "_S";
            }
            else if (day == 28)
            {
                animationName = PlanerController.Notes[4] + "_S";
            }
            Debug.Log($"{day}");
            animator.Play(animationName);
            day += 1;
        }
        else
        {
            Debug.Log("³¡");
        }
    }
}
