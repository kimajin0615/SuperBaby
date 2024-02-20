using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBtnActive : MonoBehaviour
{
    public GameObject CShopBtn;
    public GameObject IShopBtn;

    public GameObject CShop;
    public GameObject IShop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == CShop)
        {
            CShopBtn.SetActive(true);

        }
        if (other.gameObject == IShop)
        {
            IShopBtn.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == CShop)
        {
            CShopBtn.SetActive(false);

        }
        if (other.gameObject == IShop)
        {
            IShopBtn.SetActive(false);
        }
    }
}
