using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChanger : MonoBehaviour
{
    public GameObject home;
    public GameObject shop;
    public GameObject area;
    public GameObject park;

    public GameObject SelectMap;

    private GameObject mapChoiceWindow;

    // Start is called before the first frame update
    void Start()
    {
        //map = GameObject.Find("Map");

        mapChoiceWindow = GameObject.Find("MapChoice");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChoiceBtn(int index)
    {
        if(index == 1)
        {
            SelectMap = home;
            Debug.Log("집");
        }
        if (index == 2)
        {
            SelectMap = shop;
            Debug.Log("상점");
        }
        if (index == 3)
        {
            SelectMap = area;
            Debug.Log("주택가");
        }
        if (index == 4)
        {
            SelectMap = area;
            Debug.Log("공원");
        }

        
    }
    public void MoveMap()
    {
        home.SetActive(false);
        shop.SetActive(false);
        area.SetActive(false);
        park.SetActive(false);
        SelectMap.SetActive(true);
        mapChoiceWindow.SetActive(false);
    }
}
