
Intro1 = CreateDialog(function ()

    
    Talk("나","(오늘은 2024년 1월 1일 평범하게 새해를 맞이한 평범한 소시민..)","shushuF_0")
    Talk("나","(올해로 32살 평범하게 그냥저냥 잘 살고 있었다... 진짜로....)","shushuF_0")
    Talk("나","(평소와 같이 평범하게 눈을 뜬 아침)","shushuF_0")
    Talk("나","...","shushuF_0")
    Talk("나","(눈앞에 둥둥 떠있는 갓난애가 보인다)","shushuF_0")
    Talk("나","(꿈인게 분명하다. 다시 자야지)","shushuF_0")


    Talk("???","안녕하세요","shushuF_0")
    Talk("나","...","shushuF_0")
    MakeSelect("나","...", "shushuF_0", {"뭐지?", "누구야?!", "으악!"})
    Talk("???","키워주세요","shushuF_0")

    repeat 
        local selection =MakeSelect("나","...", "shushuF_0", {"주거침입자다! 당장 내보내!", "응애가 불쌍하기도 하고...일단 들어나 보자"})
        if selection==0 then
            Talk("나","(좀 죄책감이 들긴 하지만 둥둥떠다니는 갓난아기를 밀어서 문 밖으로 내보냈다)","shushuF_0")
            Talk("???","제 보호자가 되어주세요","shushuF_0")
            Talk("나","???","shushuF_0")
            Talk("나","(어느순간 다시 집 안에 들어와있다)","shushuF_0")
            Talk("???","제 보호자가 되어주세요","shushuF_0")
        end
        
    until selection == 1

    Talk("???","아 감사합니다! 늦었지만 자기소개라도 해볼까요","shushuF_0")
    Talk("???","근데 사실 자기 소개랄것도 없는게 사실 저도 눈 떠보니까 여기였거든요?","shushuF_0")
    Talk("나","...???","shushuF_0")
    Talk("???","그런데 제 보호자가 되어주신다고 하니 정말 다행이네요","shushuF_0")

    
    repeat
        local selection = MakeSelect("나","...", "shushuF_0", {"무슨 말도 안되는 소리를... 절대 사절이다", "요즘 혼자지내기에 적적하기도 했어.. 승낙하자"})
        if selection==0 then
            Talk("???","제가 갈 곳이 없어요","shushuF_0")
            Talk("???","진짜로","shushuF_0")
        end
        
      
    until selection ==1

    MakeSelect("나", "...", "shushuF_0", {"나","그럼 잘 부탁드릴게요", "오늘부터 저희 가족 할까요? ㅎㅎ...", "좋았어 오늘부터 너는 내 자식이다!"})
    

    Talk("???","저도 잘부탁드릴게요","shushuF_0")
    Talk("나","(그렇게 나는 한순간에 갓난아기의 보호자가 되었다...)","shushuF_0")
    Talk("나","(근데 나는 한번도 아이를 키워본적이 없다... 어떻게 키워야할지 물어보자)","shushuF_0")

    

    repeat
        local selection =MakeSelect("나","...", "shushuF_0", {"혹시 양육비는...?", "양육 스타일은 어떻게?", "될대로 되라지 락앤롤ㅋ"})
            if selection == 0 then
                Talk("???","아시다시피 제가 갓난아이 신분이라 돈이 없어요 죄송합니다","shushuF_0")
            elseif selection ==1  then
                Talk("???","흠... 달력이랑 할 수 있는 행동 목록 표를 정리해서 드릴테니까 일주일에 하나씩 시켜주시면 제가 그걸 해볼게요","shushuF_0")
            end
    until selection ==2

    Talk("???","그럼 잘 부탁드립니다","shushuF_0")
    Talk("나","(진짜로 갑자기.. 무언가를 키우게 되었다)","shushuF_0")
    Talk("나","(어떡하지...)","shushuF_0")
    
        
    


    


end)