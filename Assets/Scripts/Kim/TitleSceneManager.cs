using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    private void Awake()
    {
        DataManager.Instance.LoadGameData();
    }

    // ���� �����Ͱ� ������ ��Ʈ�� �ǳʶٰ� Ȩ. �ƴϸ� ��Ʈ��.
    public void LoadIntroScene()
    {
        SceneManager.LoadScene("IntroScene_Test");
    }

    public void GameExit()
    {
#if UNITY_EDITOR
        DataManager.Instance.SaveGameData();
        UnityEditor.EditorApplication.isPlaying = false;
#else
        DataManager.Instance.SaveGameData();
        Application.Quit();
#endif
    }
}
