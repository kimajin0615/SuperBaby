using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameData
{
    // ===== basic data =====
    public string name;
    public int age;
    public int month;
    public bool gender; //0 = man, 1 = woman

    public int gold = 350000;

    // ===== player condition =====
    public Dictionary<string, bool> condition = new Dictionary<string, bool>()
    {
        { "����", true },
        { "���", false },
        { "�ڳ�", false },
        { "�����ý���", false },
        { "�ΰ���", false },
        { "����Ұ�", false },
        { "����", false },
    };

    // ===== player status =====
    public Dictionary<string, int> status = new Dictionary<string, int>()
    {
        { "��Ʈ����", Math.Clamp(10, 0, 999)},
        { "ü��", Math.Clamp(400, 0, 999)},
        { "����", Math.Clamp(250, 0, 999)},
        { "��", Math.Clamp(200, 0, 999)},
        { "������", Math.Clamp(200, 0, 999)},
        { "������", Math.Clamp(200, 0, 999)},
        { "�ŷڵ�", Math.Clamp(0, -100, 100)},
        { "������", Math.Clamp(0, -100, 100)},
        { "���ǹ���", Math.Clamp(0, -100, 100)},
        { "�米��", Math.Clamp(0, -100, 100)},
        { "���", Math.Clamp(0, -100, 100)}
    };

    // ===== characters LikeGauge =====
    public Dictionary<string, int> chacracters = new Dictionary<string, int>()
    {
        { "ä��", 0 },
        { "�νþ�", 0 },
        { "�νÿ�", 0 },
        { "���ٺ�", 0 }
    };

    // ===== other data =====
}
