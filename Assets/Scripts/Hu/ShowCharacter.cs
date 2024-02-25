using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCharacter : MonoBehaviour
{
    public GameObject sia;
    public GameObject siu;
    public GameObject dabin;
    public GameObject hyun;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadGameData();
        ShowChar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowChar()
    {
        //���� ������ ��� �켱 ���� �������� �����ξ���. ������ ������ true ó���� �� �� ������ ���� �ʿ�.
        //�νþ�
        if (DataManager.Instance.gameData.age == 8 && DataManager.Instance.gameData.month == 2)
        {
            sia.SetActive(true);
        }
        //�νÿ�
        if (DataManager.Instance.gameData.age == 8 && DataManager.Instance.gameData.month == 2)
        {
            siu.SetActive(true);
        }
        //���ٺ�
        if(DataManager.Instance.gameData.age == 3 && DataManager.Instance.gameData.month == 2)
        {
            dabin.SetActive(true);
        }
        //ä��
        if(DataManager.Instance.gameData.age == 5 && DataManager.Instance.gameData.month == 2)
        {
            hyun.SetActive(true);
        }



    }
}
