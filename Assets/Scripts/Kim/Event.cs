using UnityEngine;

public class Event : MonoBehaviour
{
    public string e_Name;
    public string e_Behavior;

    public Event(string e_Name, string e_Behavior)
    {
        this.e_Name = e_Name;
        this.e_Behavior = e_Behavior;
    }
}
