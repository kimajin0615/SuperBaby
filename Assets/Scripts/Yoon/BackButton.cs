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
    public GameObject ChatButton;
    public GameObject CalenderButton;


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
            if (ChatRoom.activeSelf && !ChatList.activeSelf)
            {
                BackButtonUI.onClick.AddListener(BackToChatList);
            }

            if (ChatList.activeSelf && !ChatRoom.activeSelf)
            {
                BackButtonUI.onClick.AddListener(HomeButtonClicked);
            }
        }

        if (CalenderScreen.activeSelf)
        {
            BackButtonUI.onClick.AddListener(HomeButtonClicked);

        }

        void BackToChatList()
        {
            ChatList.SetActive(true);
            ChatScreen.SetActive(true);
            ChatRoom.SetActive(false);
            CalenderButton.SetActive(false);
            ChatButton.SetActive(false);
        }

        void HomeButtonClicked()
        {
            HomeButton.onClick.Invoke();
            ChatButton.SetActive(true);
            CalenderButton.SetActive(true);
        }
    }
}
