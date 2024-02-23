using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeSceneManager : MonoBehaviour
{
    [SerializeField] public Text NameText;
    [SerializeField] public Text AgeText;
    [SerializeField] public Text MonthText;
    [SerializeField] public Text MoneyText;

    private void Start()
    {
        NameText.text = DataManager.Instance.gameData.name;
        AgeText.text = DataManager.Instance.gameData.age + "¼¼";
        MonthText.text = DataManager.Instance.gameData.month + "¿ù";
        MoneyText.text = DataManager.Instance.gameData.gold + "¿ø";
    }
}
