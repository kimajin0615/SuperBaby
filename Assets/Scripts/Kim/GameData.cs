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
        { "보통", true },
        { "들뜸", false },
        { "자낮", false },
        { "나르시시즘", false },
        { "싸가지", false },
        { "제어불가", false },
        { "질병", false },
    };

    // ===== shushu status =====
    public Dictionary<string, int> status = new Dictionary<string, int>()
    {
        { "스트레스", Math.Clamp(10, 0, 999)},
        { "체력", Math.Clamp(400, 0, 999)},
        { "지능", Math.Clamp(250, 0, 999)},
        { "힘", Math.Clamp(200, 0, 999)},
        { "도덕성", Math.Clamp(200, 0, 999)},
        { "감수성", Math.Clamp(200, 0, 999)},
        { "신뢰도", Math.Clamp(0, -100, 100)},
        { "자존감", Math.Clamp(0, -100, 100)},
        { "예의범절", Math.Clamp(0, -100, 100)},
        { "사교성", Math.Clamp(0, -100, 100)},
        { "제어도", Math.Clamp(0, -100, 100)}
    };

    // ===== characters LikeGauge =====
    public Dictionary<string, int> chacracters = new Dictionary<string, int>()
    {
        { "채현", 0 },
        { "인시아", 0 },
        { "인시우", 0 },
        { "정다빈", 0 }
    };

    // ===== other data =====
    public Dictionary<string, int> Items = new Dictionary<string, int>()
    {
        //name, count
        { "닌X도", 0 },
        { "사탕 모양 장신구", 0 },
        { "명작 소설 모음집", 0 },
        { "모델건", 0 },
        { "밀크티", 0 },
        { "악력기", 0 },
        { "자기계발서", 0 },
        { "최면술 비법서", 0 },
        { "만화책", 0 },
        { "이상한 사탕", 0 }
    };
}
