using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSceneManager : MonoBehaviour
{
    [SerializeField] public GameObject GenderQuestion;
    [SerializeField] public GameObject NameQuestion;
    [SerializeField] private Button genderSelectBtn;
    [SerializeField] private Button nameSelectBtn;
    [SerializeField] private InputField nameInput;

    public void MaleButton() { DataManager.Instance.gameData.gender = false; }
    public void FemaleButton() { DataManager.Instance.gameData.gender = true; }
    public void GenderSelect() { genderSelectBtn.interactable = true; }

    public void LoadHomeScene()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void TurnOnNameQuestion()
    {
        GenderQuestion.SetActive(false);
        NameQuestion.SetActive(true);
    }

    public void SetName()
    {
        DataManager.Instance.gameData.name = nameInput.text;
    }

    private void Update()
    {
        if(nameInput.text != null)
        {
            nameSelectBtn.interactable = true;
        }
    }
}
