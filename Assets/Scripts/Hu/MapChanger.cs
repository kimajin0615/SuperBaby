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
    public void ChoiceBtn()
    {
        if(SelectMap == home)
        {
            home.SetActive(true);
            shop.SetActive(false);
            area.SetActive(false);
            park.SetActive(false);
            Debug.Log("집");
            mapChoiceWindow.SetActive(false);
        }
        if (SelectMap == shop)
        {
            home.SetActive(false);
            shop.SetActive(true);
            area.SetActive(false);
            park.SetActive(false);
            Debug.Log("상점");
            mapChoiceWindow.SetActive(false);
        }
        if (SelectMap == area)
        {
            home.SetActive(false);
            shop.SetActive(false);
            area.SetActive(true);
            park.SetActive(false);
            Debug.Log("주택가");
            mapChoiceWindow.SetActive(false);
        }
        if (SelectMap == park)
        {
            home.SetActive(false);
            shop.SetActive(false);
            area.SetActive(false);
            park.SetActive(true);
            Debug.Log("공원");
            mapChoiceWindow.SetActive(false);
        }

        
    }
}
