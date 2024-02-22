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

    public Dictionary<string, bool> condition = new Dictionary<string, bool>()
    {

    };

    // ===== player status =====
    public int stress = Math.Clamp(10, 0, 999);                 // ��Ʈ����
    public int health = Math.Clamp(400, 0, 999);                // ü��
    public int intellect = Math.Clamp(250, 0, 999);             // ����
    public int strength = Math.Clamp(200, 0, 999);              // ��
    public int morality = Math.Clamp(200, 0, 999);              // ������
    public int sensibility = Math.Clamp(200, 0, 999);           // ������

    public int reliability = Math.Clamp(0, -100, 100);          // �ŷڵ�
    public int selfEsteem = Math.Clamp(0, -100, 100);           // ������
    public int manners = Math.Clamp(0, -100, 100);              // ���ǹ���
    public int sociability = Math.Clamp(0, -100, 100);          // �米��
    public int controllability = Math.Clamp(0, -100, 100);      // ���


    // ===== characters LikeGauge =====
    public Dictionary<string, int> chacracters = new Dictionary<string, int>()
    {
        { "ChaeHyun", 0},
        { "InSiwoo", 0},
        { "Insia", 0},
        { "JeongDabin", 0}
    };

    // ===== other data =====
}
