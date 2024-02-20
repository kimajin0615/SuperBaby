using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeShopDB : MonoBehaviour
{
    public List<Item> item = new List<Item>();
    public bool[] soldOuts;
    // Start is called before the first frame update
    void Start()
    {
        item.Add(ItemDatabase.instance.itemDB[0]);
        item.Add(ItemDatabase.instance.itemDB[1]);
        item.Add(ItemDatabase.instance.itemDB[2]);
        item.Add(ItemDatabase.instance.itemDB[3]);
        item.Add(ItemDatabase.instance.itemDB[4]);
        item.Add(ItemDatabase.instance.itemDB[5]);
        item.Add(ItemDatabase.instance.itemDB[6]);
        item.Add(ItemDatabase.instance.itemDB[7]);
        item.Add(ItemDatabase.instance.itemDB[8]);
        item.Add(ItemDatabase.instance.itemDB[9]);
        soldOuts = new bool[item.Count];
        for (int i=0; i< soldOuts.Length; i++)
        {
            soldOuts[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
