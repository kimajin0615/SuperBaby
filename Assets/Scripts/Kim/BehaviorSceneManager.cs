using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BehaviorSceneManager : MonoBehaviour
{
    public Text monthText;
    public Text dayText;
    public Animator animator;
    public AnimationClip testAni;

    private int day = 0;

    void Start()
    {
        monthText.text = DataManager.Instance.gameData.month + "¿ù";
        animator.Play("Test");
    }

    public void FinishAnimation()
    {
        if(day < 7)
        {
            day += 1;
            dayText.text = day + "ÀÏ";
            Debug.Log($"{day}");
        }
        else
        {
            Debug.Log("³¡");
        }
    }
}
