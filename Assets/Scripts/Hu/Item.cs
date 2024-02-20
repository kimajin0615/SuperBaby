using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Item
{
    public string ItemName;
    public Sprite ItemImage;
    public string ItemInfo;
    public int price;

    public bool Sell()
    {
        return false;
    }
}
