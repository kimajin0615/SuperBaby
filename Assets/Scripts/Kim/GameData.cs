using System.Collections.Generic;
using System;
using UnityEngine;

public class GameData
{
    // ===== basic data =====
    public string name;
    public int age;
    public bool gender; //0 = male, 1 = female
    public int playerGender; // 0 = male, 1 = female, 2 = secret

    public int gold = 350000;

    public int month;
    public int day = 1;

    // ===== shushu condition =====
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

    // ===== shushu status =====
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
    public Dictionary<string, int> Items = new Dictionary<string, int>()
    {
        //name, count
        { "��X��", 0 },
        { "���� ��� ��ű�", 0 },
        { "���� �Ҽ� ������", 0 },
        { "�𵨰�", 0 },
        { "��ũƼ", 0 },
        { "�Ƿ±�", 0 },
        { "�ڱ��߼�", 0 },
        { "�ָ�� �����", 0 },
        { "��ȭå", 0 },
        { "�̻��� ����", 0 }
    };
}
