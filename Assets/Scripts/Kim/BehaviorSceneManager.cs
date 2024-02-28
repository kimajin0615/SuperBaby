using UnityEngine;
using UnityEngine.UI;

public class BehaviorSceneManager : MonoBehaviour
{
    public Text monthText;
    public Text dayText;
    public Animator animator;

    private int day = 0;

    void Start()
    {
        monthText.text = DataManager.Instance.gameData.month + "¿ù";
        animator.Play("Test");
    }

    public void FinishAnimation()
    {
        if(day < 14)
        {
            day += 1;
            dayText.text = day + "ÀÏ";
            if(day == 7)
            {
                animator.SetBool("TestBool",true);
            }
            Debug.Log($"{day}");
        }
        else
        {
            Debug.Log("³¡");
        }
    }
}
