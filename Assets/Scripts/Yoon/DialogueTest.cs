using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.Instance.RunDialog("ThreeFamily");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
