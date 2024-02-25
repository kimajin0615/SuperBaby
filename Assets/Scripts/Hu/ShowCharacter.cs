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
        //만남 판정이 없어서 우선 월을 조건으로 세워두었음. 만나기 이전에 true 처리가 될 수 있으니 수정 필요.
        //인시아
        if (DataManager.Instance.gameData.age == 8 && DataManager.Instance.gameData.month == 2)
        {
            sia.SetActive(true);
        }
        //인시우
        if (DataManager.Instance.gameData.age == 8 && DataManager.Instance.gameData.month == 2)
        {
            siu.SetActive(true);
        }
        //정다빈
        if(DataManager.Instance.gameData.age == 3 && DataManager.Instance.gameData.month == 2)
        {
            dabin.SetActive(true);
        }
        //채현
        if(DataManager.Instance.gameData.age == 5 && DataManager.Instance.gameData.month == 2)
        {
            hyun.SetActive(true);
        }



    }
}
