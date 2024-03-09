using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calender : MonoBehaviour
{
    public GameObject Schedule;
    public GameObject Content;
   

    public Transform ContentTransform;
    public Transform ScheduleTransform;
    public UnityEngine.UI.Text Month;
    public int numberOfObjects = 0;
    public int month = 1;
    bool creating = false;

    // Start is called before the first frame update
    void Start()
    {
        creating = true;
        UpdateCalendar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            month++;
            creating = true;
            UpdateCalendar();
        }
        
    }

    void UpdateCalendar()
    {
        Month.text = month + "¿ù";
        MonthSchedule();
        CreateObjects();
    }
    void MonthSchedule()
    {
        switch (month)
        {
            case 1:
                numberOfObjects = 1;
                break;
            case 2:
                numberOfObjects = 2;
                break;
            case 3:
                numberOfObjects = 3;
                break;
            case 4:
                numberOfObjects = 1;
                break;
            case 5:
                numberOfObjects = 5;
                break;
            case 6:
                numberOfObjects = 1;
                break;
            case 7:
                numberOfObjects = 4;
                break;
            case 8:
                numberOfObjects = 4;
                break;
            case 9:
                numberOfObjects = 3;
                break;
            case 10:
                numberOfObjects = 2;
                break;
            case 11:
                numberOfObjects = 2;
                break;
            case 12:
                numberOfObjects = 1;
                month = 0;
                break;
            default:
                break;
        }
    }

    void CreateObjects()
    {

       
            if (creating)
            {
                foreach (Transform child in Content.transform)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Destroy(child.gameObject);
                    }
                }

                for (int i = 0; i < numberOfObjects; i++)
                {
                    GameObject newObject = Instantiate(Schedule, ContentTransform);
                    newObject.transform.SetParent(ContentTransform);
                    newObject.transform.SetAsFirstSibling();
                }

                creating = false;
            }
       
    }
            
}

   

