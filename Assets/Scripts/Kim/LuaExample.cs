using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

//이런식으로 delegate 선언을 미리 하고, [CSharpCallLua] attribute를 달아야함
[CSharpCallLua]
public delegate void IntSetter(Int32 pInt);

[CSharpCallLua]
public delegate void VoidVoidFunction();

public class LuaExample : MonoBehaviour
{
    //테스트용 루아 스크립트가 여기에 들어감
    [SerializeField, TextArea(30, 50)] private string m_luaScript;

    //루아 환경 객체
    private LuaEnv m_luaEnv;

    //가져온 함수 저장
    private IntSetter m_setValue;
    private VoidVoidFunction m_printValue;

    private void Awake()
    {
        m_luaEnv = new LuaEnv();
        m_luaEnv.DoString(m_luaScript);
        //루아 환경에서 SetValue라는 이름의 함수를 IntSetter 형식으로 가져옴
        m_setValue = m_luaEnv.Global.Get<IntSetter>("SetValue");
        //루아 환경에서 PrintValue라는 이름의 함수를 VoidVoidFunction 형식으로 가져옴
        m_printValue = m_luaEnv.Global.Get<VoidVoidFunction>("PrintValue");
    }

    private void Update()
    {
        //루아에서 만든 함수를 가져와서 C#에서 불러서 매개변수로 넘겨주는거.
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            m_setValue(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            m_setValue(2);
        }
        //루아에 전역으로 값을 넘기는거
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            m_luaEnv.Global.Set("value", 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            m_luaEnv.Global.Set("value", 4);
        }
        //테스트용 값 프린트
        if (Input.GetKeyDown(KeyCode.P))
        {
            m_printValue();
        }
    }

    private void OnDestroy()
    {
        m_luaEnv.Dispose();
    }
}
