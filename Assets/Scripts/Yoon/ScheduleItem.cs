using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScheduleItem : MonoBehaviour
{
    public Text dateText;
    public Text eventText;
    public Text locationText;

    public void UpdateSchedule(string date, string eventText, string location)
    {
        dateText.text = date;
        this.eventText.text = eventText;
        locationText.text = location;
    }
}
