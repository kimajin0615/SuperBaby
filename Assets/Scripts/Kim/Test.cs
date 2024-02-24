using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public DataManager dataManager;

    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.Instance.RunDialog("Test");
        DataManager.Instance.LoadGameData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
