using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopSystem : MonoBehaviour
{
    public DataManager dataManager;
    //public GameObject ShopWindow;
    public GameObject ItemData;
    //public Image image;

    public Text ItemName;
    public Text infoText;
    public Text efxInfo;

    private ItemDatabase Item;

    public int ItemIndex;
    

    

    void Start()
    {
        DataManager.Instance.LoadGameData();

        Item = ItemData.GetComponent<ItemDatabase>();

        ItemName = GameObject.Find("ItemName").GetComponent<Text>();
        infoText = GameObject.Find("infoText").GetComponent<Text>();
        efxInfo = GameObject.Find("efxInfo").GetComponent<Text>();


        //image = GameObject.Find("Image").GetComponent<Image>();
        //image.sprite = Item.itemDB[ItemIndex].ItemImage;
    }
    public void LoadShopItem()
    {

        //Debug.Log(SelectItem);
        SelectItem.select(ItemIndex);

        ItemName.text = Item.itemDB[ItemIndex].ItemName;
        infoText.text = Item.itemDB[ItemIndex].ItemInfo;

    }
    public void Buy()
    {
        Debug.Log(SelectItem.selectItem);
        if (DataManager.Instance.gameData.gold < Item.itemDB[SelectItem.selectItem].price)
        {
            Debug.Log("구매 실패");
        }
        else
        {
            Debug.Log("구매 완료 : " + SelectItem.selectItem);
            DataManager.Instance.gameData.gold -= Item.itemDB[SelectItem.selectItem].price;
        }
    }
    
}
