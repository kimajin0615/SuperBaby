using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BackButton : MonoBehaviour
{
    public UnityEngine.UI.Button BackButtonUI;
    public UnityEngine.UI.Button HomeButton;


    public GameObject ChatScreen;
    public GameObject ChatList;
    public GameObject ChatRoom;
    public GameObject CalenderScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChatScreen.activeSelf)
        {
            if (ChatList.activeSelf)
            {

            }

            if (ChatRoom.activeSelf)
            {

            }
        }

        if (CalenderScreen.activeSelf)
        {
            HomeButton.onClick.Invoke();
        }
    }
}
