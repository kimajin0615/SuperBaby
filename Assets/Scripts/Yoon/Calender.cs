using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calender : MonoBehaviour
{
    public GameObject Schedule;
    public GameObject Content;

    public Transform ContentTransform;
    public Transform ScheduleTransform;
    public UnityEngine.UI.Text Month;
    public int numberOfObjects = 0;
    public int month;
    bool creating = false;

    
    public class ScheduleInfo
    {
        public string date;
        public string eventText;
        public string location;

        public ScheduleInfo(string date, string eventText, string location)
        {
            this.date = date;
            this.eventText = eventText;
            this.location = location;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        creating = true;
        UpdateCalendar();
    }

    // Update is called once per frame
    void Update()
    {
        creating = true;
        UpdateCalendar();
    }

    void UpdateCalendar()
    {
        Month.text = month + "월";
        MonthSchedule();
        CreateObjects();
    }

    void MonthSchedule()
    {
        switch (month)
        {
            case 1:
                numberOfObjects = 6;
                break;
            case 2:
                numberOfObjects = 11;
                break;
            case 3:
                numberOfObjects = 8;
                break;
            case 4:
                numberOfObjects = 12;
                break;
            case 5:
                numberOfObjects = 10;
                break;
            case 6:
                numberOfObjects = 12;
                break;
            default:
                break;
        }
    }

    void CreateObjects()
    {
             foreach (Transform child in Content.transform)
        {
            Destroy(child.gameObject);
        }

        
        switch (month)
        {
            case 1:
                CreateScheduleObjects(new ScheduleInfo[]
                {
                    new ScheduleInfo("1월 2일", "출생신고 외출", "X"),
                    new ScheduleInfo("1월 18일", "채현 생일", "X"),
                    new ScheduleInfo("1월 20일", "정다빈 가족과 우연히 극장에서 마주침", "연극 감상"),
                    new ScheduleInfo("1월 24일", "초등학교 입학 준비", "X"),
                    new ScheduleInfo("1월 25일", "시우 도련님과 방과후 다도 모임", "다도"),
                    new ScheduleInfo("1월 31일", "채현자식 과외 시켜주기", "수능 공부")
                });
                break;
            case 2:
                CreateScheduleObjects(new ScheduleInfo[]
                {
                    new ScheduleInfo("2월 16일", "쇼핑몰 외출", "X"),
                    new ScheduleInfo("2월 17일", "채현 첫등장", "X"),
                    new ScheduleInfo("2월 25일", "첫 핸드폰", "X"),
                    new ScheduleInfo("2월 29일", "정다빈 첫등장", "X"),
                    new ScheduleInfo("2월 29일", "무술 메이트 시아 아가씨", "무술")
                });
                break;
            case 3:
                CreateScheduleObjects(new ScheduleInfo[]
                {
                    new ScheduleInfo("3월 5일", "한국어 교육 시도", "X"),
                    new ScheduleInfo("3월 19일", "현장체험학습", "X"),
                    new ScheduleInfo("3월 27일", "정다빈 생일", "X"),
                    new ScheduleInfo("3월 33일", "초능력 수행평가", "X"),
                    new ScheduleInfo("3월 15일", "힘들어보이는 다빈쓰를 위한 차한잔", "다도"),
                    new ScheduleInfo("3월 22일", "시아 아가씨와 방과후 미적 감각을 늘리기 위한 활동", "미술"),
                    new ScheduleInfo("3월 17일", "시아 아가씨에게 배우는 리얼 사회생활", "사회생활 준비"),
                    new ScheduleInfo("3월 3일", "시험 당일", "X")
                });
                break;
            case 4:
                CreateScheduleObjects(new ScheduleInfo[]
                {
                    new ScheduleInfo("4월 5일", "학원에서 정다빈과 마주침", "교과 학원"),
                    new ScheduleInfo("4월 7일", "학원 땡땡이 치려는 다빈쓰 목격!", "교과 학원"),
                    new ScheduleInfo("4월 11일", "체육대회", "X"),
                    new ScheduleInfo("4월 18일", "추석", "X"),
                    new ScheduleInfo("4월 25일", "시아 아가씨의 프라이빗 극장", "연극 감상"),
                    new ScheduleInfo("4월 26일", "세가족 소풍", "X"),
                    new ScheduleInfo("4월 28일", "옷가게 알바 슈슈 구경하는 부잣집 아가씨 시아", "옷가게")
                });
                break;
            case 5:
                CreateScheduleObjects(new ScheduleInfo[]
                {
                    new ScheduleInfo("5월 3일", "시아시우 생일 (시아)", "X"),
                    new ScheduleInfo("5월 3일", "시아시우 생일", "X"),
                    new ScheduleInfo("5월 10일", "반친구와 싸움", "X"),
                    new ScheduleInfo("5월 10일", "수학여행 준비", "X"),
                    new ScheduleInfo("5월 13일", "집에 가다가 외국인에게 붙잡힌 시우 구출", "제2 외국어"),
                    new ScheduleInfo("5월 17일", "수능", "X"),
                    new ScheduleInfo("5월 24일", "시아 아가씨랑 (비싼)연극 보는 날", "연극 감상"),
                    new ScheduleInfo("5월 28일", "시아 아가씨의 모델이 되어보자", "미술")
                });
                break;
            case 6:
                CreateScheduleObjects(new ScheduleInfo[]
                {
                    new ScheduleInfo("6월 11일", "시우 도련님과 방과후 독서 모임", "독서"),
                    new ScheduleInfo("6월 12일", "학교 축제", "X"),
                    new ScheduleInfo("6월 14일", "시아 아가씨와 외출, 외국인 만남 어버버", "제2 외국어"),
                    new ScheduleInfo("6월 19일", "중학교 졸업식", "X"),
                    new ScheduleInfo("6월 21일", "인씨 가문 대저택 방문", "X"),
                    new ScheduleInfo("6월 25일", "졸업 전 기념 여행", "X"),
                    new ScheduleInfo("6월 26일", "친구들과 게임", "X"),
                    new ScheduleInfo("6월 28일", "백수 방문객 채현을 위한 음식 대접", "요리"),
                    new ScheduleInfo("6월 31일", "크리스마스 선물 증정식", "X")
                });
                break;
            default:
                break;
        }

        creating = false;
    }

    // 일정 오브젝트 생성 함수
    void CreateScheduleObjects(ScheduleInfo[] schedules)
    {
        for (int i = 0; i < schedules.Length; i++)
        {
            GameObject newObject = Instantiate(Schedule, ContentTransform);
            newObject.transform.SetParent(ContentTransform);

            // 일정 정보 업데이트
            ScheduleItem scheduleItem = newObject.GetComponent<ScheduleItem>();
            scheduleItem.UpdateSchedule(schedules[i].date, schedules[i].eventText, schedules[i].location);
        }
    }
}
