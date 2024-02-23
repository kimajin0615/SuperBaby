using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NotebookController : MonoBehaviour
{
    [SerializeField] public Slider[] sliders;
    [SerializeField] public Text Name;
    [SerializeField] public Text Age;
    private int index;

    public void SetNotebook()
    {
        index = 0;
        foreach(var item in DataManager.Instance.gameData.status)
        {
            sliders[index].value = item.Value;
            index++;
        }

        Name.text = DataManager.Instance.gameData.name;
        Age.text = DataManager.Instance.gameData.age + "¼¼";
    }
}
