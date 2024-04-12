using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject HomeCanvas;
    public GameObject BehaviorCanvas;
    public Animator animator;

    public void HomeCanvasOnOff(bool tag)
    {
        HomeCanvas.SetActive(tag);
    }

    public void BehaviorCanvasOnOff(bool tag)
    {
        BehaviorCanvas.SetActive(tag);
    }

    public void AnimatorOnOff(bool tag)
    {
        animator.gameObject.SetActive(tag);
    }
}
