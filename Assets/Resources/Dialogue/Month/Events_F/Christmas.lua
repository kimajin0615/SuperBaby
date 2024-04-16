
Christmas = CreateDialog(function ()

    
    name = "슈슈"
    

    Talk("나","(오늘은 크리스마스)","shushuF_12")
    Talk("나","(오랜만에 크리스마스 선물을 주기로 했다)","shushuF_12")

    MakeSelect("나","(내가 준비한것은...)", "shushuF_12", {"지갑"})

    Talk(name,"안녕히주무셨어요","shushuF_12")
    Talk("나","잘 잤어?","shushuF_12")
    Talk(name,"네","shushuF_12")
    Talk(name,"근데 그거 뭐예요?","shushuF_12")
    Talk("나","아 이거 크리스마스 선물","shushuF_12")
    Talk(name,"아","shushuF_12")
    Talk(name,"크리스마스라고 선물 주고받는거 오랜만이네요","shushuF_12")
    Talk("나","그러게 초등학교때 좀 하다 말았나?","shushuF_12")
    Talk(name,"좀 그런거 하기엔 유치하긴 했어요","shushuF_12")
    Talk(name,"근데 왜 다시?","shushuF_12")

    local selection = MakeSelect("나","음..", "shushuF_12", {"옛날이 그리워서", "요즘따라 감성이 챙기고 싶어서?", "왜? 싫어?"})
        if selection==0 then
            Talk(name,"추억 재연 좋죠 뭐","shushuF_12")
            Talk("나","음 오랜만에 다시 하는것도 좋지","shushuF_12")
        elseif selection==1 then
            Talk(name,"나이 들면 사람이 좀 감성적이게 된다는데 그거?","shushuF_12")
            Talk(name,"근데 그건 좀 이른거같은데...","shushuF_12")
            Talk("나","아니야 그런거","shushuF_12")
            Talk("나","그냥 오늘따라 그런거지 평소에는 안그래!","shushuF_12")
        elseif selection==2 then
            Talk(name,"아뇨 뭐 싫을리가","shushuF_12")

        end

    Talk(name,"그래서 뭐 준비하신거예요?","shushuF_12")
    Talk(name,"열어봐도 되는거죠?","shushuF_12")
    Talk("나","물론이지 열어봐","shushuF_12")
    Talk("","(부시럭부시럭)","shushuF_12")
    Talk(name,"오 지갑","shushuF_12")
    Talk("나","앞으로 돈 쓸일도 많아질거고 이제 카드도 있으니까","shushuF_12")
    Talk("나","지갑 슬슬 필요할 것 같아서 준비했어","shushuF_12")
    Talk(name,"안그래도 지금 제 지갑 다이소에서 산 1000원짜리 동전지갑이예요","shushuF_12")
    Talk(name,"필요하다고 생각할 참이였는데","shushuF_12")
    Talk(name,"감사합니다","shushuF_12")
    Talk("나","고맙긴","shushuF_12")
    Talk("나","앞으로도 잘 지내자고 주는 뇌물이야","shushuF_12")
    Talk(name,"헉...","shushuF_12")
    
end)