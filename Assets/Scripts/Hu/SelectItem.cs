using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    public static int selectItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static int select(int index)
    {
        selectItem = index;
        Debug.Log(selectItem);
        return selectItem;
    }
}
