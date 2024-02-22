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
    public int stress = Math.Clamp(10, 0, 999);                 // 스트레스
    public int health = Math.Clamp(400, 0, 999);                // 체력
    public int intellect = Math.Clamp(250, 0, 999);             // 지능
    public int strength = Math.Clamp(200, 0, 999);              // 힘
    public int morality = Math.Clamp(200, 0, 999);              // 도덕성
    public int sensibility = Math.Clamp(200, 0, 999);           // 감수성

    public int reliability = Math.Clamp(0, -100, 100);          // 신뢰도
    public int selfEsteem = Math.Clamp(0, -100, 100);           // 자존감
    public int manners = Math.Clamp(0, -100, 100);              // 예의범절
    public int sociability = Math.Clamp(0, -100, 100);          // 사교성
    public int controllability = Math.Clamp(0, -100, 100);      // 제어도


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
