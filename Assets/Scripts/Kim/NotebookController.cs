using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NotebookController : MonoBehaviour
{
    //public Slider healthGaugeBar;
    //public Slider intellectGaugeBar;
    //public Slider StrengthGaugeBar;
    //public Slider MoralityGaugeBar;
    //public Slider SensibilityGaugeBar;
    //public Slider ReliabilityGaugeBar;
    //public Slider StressGaugeBar;

    //public Slider ReliabilityBar;
    //public Slider SelfEsteemBar;
    //public Slider MannersBar;
    //public Slider SociabilityBar;
    //public Slider ControllabilityBar;

    [SerializeField]
    public Slider[] sliders;
    private int index;

    public void SetStatus()
    {
        index = 0;
        foreach(var item in DataManager.Instance.gameData.status)
        {
            sliders[index].value = item.Value;
            index++;
        }
    }
}
