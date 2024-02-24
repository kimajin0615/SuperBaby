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

    // 기존 데이터가 있으면 인트로 건너뛰고 홈. 아니면 인트로.
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
