using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTest : MonoBehaviour
{
    public static string date;

    public static void SetDate(string m_date)
    {
        date = m_date;
    }

    // Start is called before the first frame update
    void Start()
    {
        if(date == "0/0/0")
        {
            DialogueManager.Instance.RunDialog("Intro1");
        }
        else if(date == "0/1/2")
        {
            DialogueManager.Instance.RunDialog("SayBirth");
        }
        else if(date == "0/2/16")
        {
            DialogueManager.Instance.RunDialog("Shopping");
        }
        else if (date == "0/6/26")
        {
            DialogueManager.Instance.RunDialog("Superpower");
        }
        else if (date == "3/5/12")
        {
            DialogueManager.Instance.RunDialog("SleepWithMIT");
        }
        else if (date == "5/3/5")
        {
            DialogueManager.Instance.RunDialog("StudyEnglish");
        }
        else if(date =="5/4/26")
        {
            DialogueManager.Instance.RunDialog("ThreeFamily");
        }
        else if (date == "5/5/8")
        {
            DialogueManager.Instance.RunDialog("ParentsDay");
        }
        else if (date == "8/1/24")
        {
            DialogueManager.Instance.RunDialog("ElementarySchool");
        }
        else if (date == "8/5/10")
        {
            DialogueManager.Instance.RunDialog("FightFriend");
        }
        else if (date == "12/2/25")
        {
            DialogueManager.Instance.RunDialog("HavePhone");
        }
        else if (date == "15/4/25")
        {
            DialogueManager.Instance.RunDialog("PromotionParty");
        }
        else if (date == "15/6/31")
        {
            DialogueManager.Instance.RunDialog("Christmas");
        }
        else if (date == "16/1/26")
        {
            DialogueManager.Instance.RunDialog("TravelOnlyTwo");
        }
        else if (date == "16/4/18")
        {
            DialogueManager.Instance.RunDialog("ThanksDay");
        }
        else if (date == "17/5/10")
        {
            DialogueManager.Instance.RunDialog("MathTravel");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
