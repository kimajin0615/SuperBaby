using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.Instance.RunDialog("LuaLua");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
