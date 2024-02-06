using DialogueSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;


[CSharpCallLua]
public interface Car
{
    //Single == float
    Single GetSpeed();
    void SetSpeed(Single speed);
    void Drive();
}


public class LuaRunner : MonoBehaviour
{
    [SerializeField] private TextAsset m_luaScript;
    private LuaEnv m_luaEnv;

    private void Awake()
    {
        m_luaEnv = new LuaEnv();
    }

    //[InspectorButton("Run Lua")]
    //private void RunLua()
    //{
    //    //lua ½ÇÇà
    //    m_luaEnv.DoString(m_luaScript.text);
    //}

    //[InspectorButton("Get Car")]
    //private void GetCar()
    //{
    //    Car luaCar = m_luaEnv.Global.Get<Car>("luaCar");
    //    Debug.Log(luaCar.GetSpeed());
    //    luaCar.SetSpeed(20);
    //    Debug.Log(luaCar.GetSpeed());
    //    luaCar.Drive();
    //}
}


