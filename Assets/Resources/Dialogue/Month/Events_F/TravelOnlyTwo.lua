
TravelOnlyTwo = CreateDialog(function ()

  

    name = "슈슈"


    Talk("나","우리 즉석 여행 다녀올까","shushuF_18")
    Talk(name,"언제요?","shushuF_18")
    Talk("나","오늘","shushuF_18")
    Talk(name,"네...?","shushuF_18")
    Talk(name,"이렇게까지 즉석이여도 되는거예요?","shushuF_18")
    Talk("나","아니 뭐 학교는 방학이고","shushuF_18")
    Talk("나","난.. 오늘을 위해서 연차를 남겨둔거라고 생각해","shushuF_18")
    Talk(name,"아닌거같으니까 다녀오세요","shushuF_18")
    local selection = MakeSelect("나", "...", "shushuF_18", {"알았어....", "아니! 난 진심이야! 나는 오늘을 위해 연차를 남긴게 틀림없다고!!"})
    if selection==0 then
        Talk(name,"네 빨리 다녀오세요 또 늦기 전에","shushuF_18")
        Talk("나","데ㄹ..","shushuF_18")
        Talk(name,"안데려다 드릴거니까 빨리 가세요","shushuF_18")
        Talk("나","응..","shushuF_18")
    
    elseif selection==1 then
        Talk(name,"...","shushuF_18")
        Talk("나","응 난 오늘을 위해 연차를 남긴거야","shushuF_18")
        Talk(name,"어디 가고싶으신데요?","shushuF_18")

        local selection2 = MakeSelect("나","흠..", "shushuF_18", {"맑은 공기 울창한 숲! 아름다운 새의 노랫소리! 그리고 동물! 얼마나 좋을까.. 난 산이 좋아", "아름다운 수평선, 물에 비치는 햇빛, 바다냄새와 갈매기 해수욕장! 바다가 좋아","높고 깊은 산 속에 넓은 계곡.. 그만큼 시원하고 아름다운 곳이 없지"})
        if selection2==0 or selection2==2 then
            Talk(name,"산.....?","shushuF_18")
            Talk("나","어","shushuF_18")
            Talk(name,"산에 모기 많아서 싫어요","shushuF_18")
            local selection3 = MakeSelect("나","...", "shushuF_18", {"그럼 어디가 좋은데",  "그럼 바다나 갈까~"})
            if selection3==0 then
                Talk(name,"산 아니면 바다죠 뭐","shushuF_18")
                Talk(name,"바다가 차라리 나을거같은데 바다로 가요","shushuF_18")
                Talk(name,"이왕이면 하와이로?","shushuF_18")
            end
        else
            Talk(name,"아 그래요","shushuF_18")
            Talk(name,"바다 좋아요","shushuF_18")
            Talk(name,"딱히 좋다는건 아닌데 좋은듯?","shushuF_18")
            Talk(name,"흠","shushuF_18")
            Talk("나","그럼 준비하고 출발해볼까","shushuF_18")
            Talk(name,"어디 바다 갈 생각인데요?","shushuF_18")
            local selection3 = MakeSelect("나", "음...", "shushuF_18", {"동해", "서해", "남해"})
            if selection3==0 then
                Talk("나","동해에 목포항 어때","shushuF_18")
                Talk("나","저번에 직장 동료가 가봤는데 한적하고 좋다더라고 얘기한걸 들었는데","shushuF_18")
                Talk("나","뭔가 끌려서 가보고싶더라","shushuF_18")
            elseif selection3==1 then
                Talk("나","서해는 잘 안가봤으니까....","shushuF_18")
                Talk("나","그냥 서해에 적당한 해수욕장이면 되지 않을까?","shushuF_18")
            elseif selection3==2 then
                Talk("나","남해,,, 하면 부산이나 인천인데 상관 없지..?","shushuF_18")
                Talk("나","둘중에 네가 가고싶은 곳으로 가자","shushuF_18")
                Talk("나","어디로 갈래?","shushuF_18")
                Talk(name,"흠....","shushuF_18")
                Talk(name,"저는 하와이가 가고싶은데요","shushuF_18")
                Talk("나","하와이?","shushuF_18")
                Talk("나","거길 어떻게 가","shushuF_18")
                Talk("나","하루 당일치기로 다녀오는건데...","shushuF_18")
                Talk(name,"아뇨 갈수 있죠 왜 못가요?","shushuF_18")
                Talk("나","어떻ㄱ","shushuF_18")
            end
        end

        Talk("","--- 하와이 ---","None")
        Talk("나","헉","None")
        Talk("나","왜 해외를 못간다고 생각한거지...","None")
        Talk("나","내 딸/아들은 초능력잔데.....","None")
        Talk(name,"흠","shushuF_18")
        Talk("지나가는 행인 1","Aloha~","None")
        Talk("나","아,,,알로하~~","None")
        Talk("나","","None")
        Talk(name,"자식 하나 잘 두신 것 같네요","shushuF_18")
        Talk(name,"부러워라~","shushuF_18")
        Talk("나","딸램/아들램! 저기 가보자","None")
        Talk("나","맛있는거 파나본데??","None")
        Talk("","(와글와글)","None")
        Talk("","이거 먹어봐 맛있다","None")
        Talk("","아뇨 저는 괜찮,, 웁","None")
        Talk("","마히에혀","None")
        Talk("","그치 이것도 먹어","None")
        Talk("","아이..!","None")
    
        
    end
 
    
end)