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
            AdjustStatus("����", 4);
            AdjustStatus("������", 4);
            AdjustStatus("��Ʈ����", 2);
        }
        else
        {
            AdjustStatus("����", 2);
            AdjustStatus("������", 2);
            AdjustStatus("��Ʈ����", 4);
        }
    }
    public void ArtStatus(bool isSuccess)
    {
        if (isSuccess)
        {
            AdjustStatus("������", 4);
            AdjustStatus("��", -4);
            AdjustStatus("��Ʈ����", -2);
        }
        else
        {
            AdjustStatus("������", 2);
            AdjustStatus("��", -2);
            AdjustStatus("��Ʈ����", -1);
        }
    }

    public void SubjectStatus(bool isSuccess)
    {
        if (isSuccess)
        {
            AdjustStatus("����", 4);
            AdjustStatus("��Ʈ����", 2);
            AdjustStatus("������", -4);
            AdjustStatus("������", -2);
        }
        else
        {
            AdjustStatus("����", 2);
            AdjustStatus("��Ʈ����", 4);
            AdjustStatus("������", -6);
            AdjustStatus("������", -4);
        }
    }

}
