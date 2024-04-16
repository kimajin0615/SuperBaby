using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

//�̷������� delegate ������ �̸� �ϰ�, [CSharpCallLua] attribute�� �޾ƾ���
[CSharpCallLua]
public delegate void IntSetter(Int32 pInt);

[CSharpCallLua]
public delegate void VoidVoidFunction();

public class LuaExample : MonoBehaviour
{
    //�׽�Ʈ�� ��� ��ũ��Ʈ�� ���⿡ ��
    [SerializeField, TextArea(30, 50)] private string m_luaScript;

    //��� ȯ�� ��ü
    private LuaEnv m_luaEnv;

    //������ �Լ� ����
    private IntSetter m_setValue;
    private VoidVoidFunction m_printValue;

    private void Awake()
    {
        m_luaEnv = new LuaEnv();
        m_luaEnv.DoString(m_luaScript);
        //��� ȯ�濡�� SetValue��� �̸��� �Լ��� IntSetter �������� ������
        m_setValue = m_luaEnv.Global.Get<IntSetter>("SetValue");
        //��� ȯ�濡�� PrintValue��� �̸��� �Լ��� VoidVoidFunction �������� ������
        m_printValue = m_luaEnv.Global.Get<VoidVoidFunction>("PrintValue");
    }

    private void Update()
    {
        //��ƿ��� ���� �Լ��� �����ͼ� C#���� �ҷ��� �Ű������� �Ѱ��ִ°�.
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            m_setValue(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            m_setValue(2);
        }
        //��ƿ� �������� ���� �ѱ�°�
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            m_luaEnv.Global.Set("value", 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            m_luaEnv.Global.Set("value", 4);
        }
        //�׽�Ʈ�� �� ����Ʈ
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
