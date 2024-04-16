using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BehaviorManager : MonoBehaviour
{
    public Text monthText;
    public Text dayText;
    public Animator animator;
    //public GameObject HomeCanvas;
    public GameObject canvasManager;

    private GameObject planerController;
    private int day;
    private string animationName;

    private void Awake()
    {
        canvasManager = GameObject.Find("CanvasManager");
    }

    private void OnEnable()
    {
        planerController = GameObject.Find("Calendar"); // <-
        canvasManager.GetComponent<CanvasManager>().HomeCanvasOnOff(false);
        monthText.text = DataManager.Instance.gameData.month + "월";
    }

    private void Start()
    {
        day = DataManager.Instance.gameData.day;
        FinishAnimation();
    }

    public void FinishAnimation()
    {
        if(day < 35)
        {
            dayText.text = day + "일";

            if (day == 1) { animationName = planerController.GetComponent<PlanerController>().Notes[0]; }
            else if (day == 7) { animationName = planerController.GetComponent<PlanerController>().Notes[1]; }
            else if (day == 14) { animationName = planerController.GetComponent<PlanerController>().Notes[2]; }
            else if (day == 21) { animationName = planerController.GetComponent<PlanerController>().Notes[3]; }
            else if (day == 28) { animationName = planerController.GetComponent<PlanerController>().Notes[4]; }
            Debug.Log($"{day} : {animationName}");

            animator.SetTrigger(animationName);
            // 성공 실패 나누기
            animator.Play(animationName + "_S");

            foreach(var date in Date.eventDates) // 그냥 딕셔너리로 해도 된거같긴한데 그거 너무 보기가 안좋달까... 잘 안들어온달까...흠.. 그래도 그걸쓰는게 효율이 좋으려남능람;ㄴㅏ 멀라 걍 해
            {
                if(date.Key == DataManager.Instance.gameData.age + "/" + DataManager.Instance.gameData.month + "/" + day)
                {
                    Debug.Log($"key : {date.Key}");
                    if(date.Value.e_Behavior != null)
                    {
                        if (date.Value.e_Behavior != animationName) break;
                    }

                    DataManager.Instance.gameData.day = day  + 1;

                    DialogueTest.SetDate(date.Key);
                    SceneManager.LoadScene("TalkScene");

                    break;
                }
            }
            day += 1;
        }
        else
        {
            Debug.Log("끝");
            DataManager.Instance.gameData.day = 1;
            DataManager.Instance.SaveGameData();

        }
    }
}
