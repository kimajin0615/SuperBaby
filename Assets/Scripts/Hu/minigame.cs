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
            Success();
        }
        else
        {
            Failed();
        }
    }
    public void Success()
    {
       if(NowObj == 1)
        {

        }
        if (NowObj == 2)
        {


        }
        if (NowObj == 3)
        {

        }
    }
    public void Failed()
    {
        if(NowObj == 1)
        {

        }
        if (NowObj == 2)
        {


        }
        if (NowObj == 3)
        {

        }
    }
}
