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
        AgeText.text = DataManager.Instance.gameData.age + "세";
        MonthText.text = DataManager.Instance.gameData.month + "월";
        MoneyText.text = DataManager.Instance.gameData.gold + "원";

        // 달 시작 대화
        // 나이 체크 후 스탠딩
    }
}
