using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "BeHaviorObject", menuName = "ScriptableObject/BeHaviorObject", order = 1)]
public class Behavior : ScriptableObject
{
    public int type;
    public Sprite icon;
    public string englishName;
    public string name;
    public int cost;
    public int unlockAge;
}
