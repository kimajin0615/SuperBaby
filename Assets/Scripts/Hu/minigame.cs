using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame : MonoBehaviour
{

    public GameObject Obj;
    public int chance;
    public int NowObj;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadGameData();
        if (Obj == GameObject.Find("water"))
        {
            NowObj = 1;
        }
        if (Obj == GameObject.Find("bench"))
        {
            NowObj = 2;
        }
        if (Obj == GameObject.Find("stretch"))
        {
            NowObj = 3;
        }
    }
    void Update()
    {
        
    }
    public void RandNumber()
    {
        chance = Random.Range(0, 10);

        if(chance >= 3)
        {
            Debug.Log("����");
            Success();
        }
        else
        {
            Debug.Log("����");
            Failed();
        }
    }
    public void Success()
    {
       if(NowObj == 1)
        {
            //���� + 20 ������ + 20    ������ + 20   �米�� + 15    ��Ʈ���� - 20
            DataManager.Instance.gameData.status["����"] += 20;
            DataManager.Instance.gameData.status["������"] += 20;
            DataManager.Instance.gameData.status["������"] += 20;
            DataManager.Instance.gameData.status["�米��"] += 15;
            DataManager.Instance.gameData.status["��Ʈ����"] -= 20;
        }
        if (NowObj == 2)
        {
            DataManager.Instance.gameData.condition["����"] = false;
            DataManager.Instance.gameData.condition["�ڳ�"] = false;
            DataManager.Instance.gameData.condition["�����ý���"] = false;
            DataManager.Instance.gameData.condition["�ΰ���"] = false;
            DataManager.Instance.gameData.condition["����Ұ�"] = false;
            DataManager.Instance.gameData.condition["����"] = false;

            DataManager.Instance.gameData.condition["���"] = true;

        }
        if (NowObj == 3)
        {
            //ü�� + 20	�� + 20	��� + 15		��Ʈ���� - 20
            DataManager.Instance.gameData.status["ü��"] += 20;
            DataManager.Instance.gameData.status["��"] += 20;
            DataManager.Instance.gameData.status["���"] += 15;
            DataManager.Instance.gameData.status["��Ʈ����"] -= 20;
        }
    }
    public void Failed()
    {
        if (NowObj == 1)
        {
            //���� + 10	������ + 10	������  + 10	�米�� + 7	��Ʈ���� - 10
            DataManager.Instance.gameData.status["����"] += 10;
            DataManager.Instance.gameData.status["������"] += 10;
            DataManager.Instance.gameData.status["������"] += 10;
            DataManager.Instance.gameData.status["�米��"] += 7;
            DataManager.Instance.gameData.status["��Ʈ����"] -= 10;
        }
        if (NowObj == 2)
        {
            Debug.Log("���� ����");

        }
        if (NowObj == 3)
        {
            // ü�� + 10    �� + 10  ��� + 7     ��Ʈ���� - 10
            DataManager.Instance.gameData.status["ü��"] += 10;
            DataManager.Instance.gameData.status["��"] += 10;
            DataManager.Instance.gameData.status["���"] += 7;
            DataManager.Instance.gameData.status["��Ʈ����"] -= 10;
        }
    }
}
