using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapmanager : MonoBehaviour
{
    public static GameObject home;
    public static GameObject shop;
    public static GameObject area;
    public static GameObject park;
    // Start is called before the first frame update
    void Start()
    {
        home = transform.GetChild(0).gameObject;
        shop = transform.GetChild(1).gameObject;
        area = transform.GetChild(2).gameObject;
        park = transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
