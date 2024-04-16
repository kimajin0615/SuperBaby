using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusController : MonoBehaviour
{
    public static void AdjustStatus(string statusName, int value)
    {
        DataManager.Instance.gameData.status[statusName] += value;
    }

    public void ReadBookStatus(bool isSuccess)
    {
        if (isSuccess)
        {
            AdjustStatus("지능", 4);
            AdjustStatus("감수성", 4);
            AdjustStatus("스트레스", 2);
        }
        else
        {
            AdjustStatus("지능", 2);
            AdjustStatus("감수성", 2);
            AdjustStatus("스트레스", 4);
        }
    }
    public void ArtStatus(bool isSuccess)
    {
        if (isSuccess)
        {
            AdjustStatus("감수성", 4);
            AdjustStatus("힘", -4);
            AdjustStatus("스트레스", -2);
        }
        else
        {
            AdjustStatus("감수성", 2);
            AdjustStatus("힘", -2);
            AdjustStatus("스트레스", -1);
        }
    }

    public void SubjectStatus(bool isSuccess)
    {
        if (isSuccess)
        {
            AdjustStatus("지능", 4);
            AdjustStatus("스트레스", 2);
            AdjustStatus("감수성", -4);
            AdjustStatus("자존감", -2);
        }
        else
        {
            AdjustStatus("지능", 2);
            AdjustStatus("스트레스", 4);
            AdjustStatus("감수성", -6);
            AdjustStatus("자존감", -4);
        }
    }

}
