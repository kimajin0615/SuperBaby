using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public static int CoinInt; // ������ ����Ǵ� ����
    
    public static Text CoinText; // ������ ǥ���� ������Ʈ
    public static Text MSG; // �޽��� ����

    // Start is called before the first frame update
    void Start()
    {
        CoinText = GameObject.Find("GoldText").GetComponent<Text>();
        CoinInt = PlayerPrefs.GetInt("coin", 300); // PlayerPrefs ���� ����Ǿ��ִ� 'Coin'�� �ҷ��� CoinInt�� �����մϴ�. ���࿡ ����� ������ ���ٸ� 0�� �����մϴ�.
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Coin", CoinInt); // CoinInt�� PlayerPrefs ����  ����Ǿ��ִ� 'Coin'�� �����մϴ�.

        CoinText.text = CoinInt.ToString() + "��"; //CoinText�� Text�� CoinInt�� ����մϴ�.

    }
}
