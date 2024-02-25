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
            Debug.Log("성공");
            Success();
        }
        else
        {
            Debug.Log("실패");
            Failed();
        }
    }
    public void Success()
    {
       if(NowObj == 1)
        {
            //지능 + 20 도덕성 + 20    감수성 + 20   사교성 + 15    스트레스 - 20
            DataManager.Instance.gameData.status["지능"] += 20;
            DataManager.Instance.gameData.status["도덕성"] += 20;
            DataManager.Instance.gameData.status["감수성"] += 20;
            DataManager.Instance.gameData.status["사교성"] += 15;
            DataManager.Instance.gameData.status["스트레스"] -= 20;
        }
        if (NowObj == 2)
        {
            DataManager.Instance.gameData.condition["보통"] = false;
            DataManager.Instance.gameData.condition["자낮"] = false;
            DataManager.Instance.gameData.condition["나르시시즘"] = false;
            DataManager.Instance.gameData.condition["싸가지"] = false;
            DataManager.Instance.gameData.condition["제어불가"] = false;
            DataManager.Instance.gameData.condition["질병"] = false;

            DataManager.Instance.gameData.condition["들뜸"] = true;

        }
        if (NowObj == 3)
        {
            //체력 + 20	힘 + 20	제어도 + 15		스트레스 - 20
            DataManager.Instance.gameData.status["체력"] += 20;
            DataManager.Instance.gameData.status["힘"] += 20;
            DataManager.Instance.gameData.status["제어도"] += 15;
            DataManager.Instance.gameData.status["스트레스"] -= 20;
        }
    }
    public void Failed()
    {
        if (NowObj == 1)
        {
            //지능 + 10	도덕성 + 10	감수성  + 10	사교성 + 7	스트레스 - 10
            DataManager.Instance.gameData.status["지능"] += 10;
            DataManager.Instance.gameData.status["도덕성"] += 10;
            DataManager.Instance.gameData.status["감수성"] += 10;
            DataManager.Instance.gameData.status["사교성"] += 7;
            DataManager.Instance.gameData.status["스트레스"] -= 10;
        }
        if (NowObj == 2)
        {
            Debug.Log("변경 없음");

        }
        if (NowObj == 3)
        {
            // 체력 + 10    힘 + 10  제어도 + 7     스트레스 - 10
            DataManager.Instance.gameData.status["체력"] += 10;
            DataManager.Instance.gameData.status["힘"] += 10;
            DataManager.Instance.gameData.status["제어도"] += 7;
            DataManager.Instance.gameData.status["스트레스"] -= 10;
        }
    }
}
