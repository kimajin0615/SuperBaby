using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public static int CoinInt; // 코인이 저장되는 변수
    
    public static Text CoinText; // 코인을 표시할 오브젝트
    public static Text MSG; // 메시지 내용

    // Start is called before the first frame update
    void Start()
    {
        CoinText = GameObject.Find("GoldText").GetComponent<Text>();
        CoinInt = PlayerPrefs.GetInt("coin", 300); // PlayerPrefs 내에 저장되어있는 'Coin'을 불러와 CoinInt에 저장합니다. 만약에 저장된 정보가 없다면 0을 저장합니다.
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Coin", CoinInt); // CoinInt를 PlayerPrefs 내에  저장되어있는 'Coin'에 저장합니다.

        CoinText.text = CoinInt.ToString() + "원"; //CoinText의 Text에 CoinInt를 출력합니다.

    }
}
