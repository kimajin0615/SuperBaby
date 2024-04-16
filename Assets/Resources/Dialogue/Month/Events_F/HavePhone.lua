
HavePhone = CreateDialog(function ()

    name = "슈슈"

    Talk("나","(오늘은 퇴근길에 핸드폰을 구매했다)","None")
    Talk("나","(살짝 늦은 감이 없잖아 있지만... 그래도 친구들이랑 대화하고 놀고 하려면 있는게 좋지 않을까 싶어서 구매했다)","None")
    Talk("나","(좋아해줬으면 좋겠는데...)","None")
    
    Talk("","--- 집 ---", "None")
    Talk("나","다녀왔어","None")
    Talk(name,"다녀오셨어요","shushuF_12")


    local selection = MakeSelect("나","...", "shushuF_12", {"자, 내가 뭘 가져왔게~~??", "이거 받아", "가위바위보 이기면 이거 줄게"})
    if selection==0 then
        Talk(name,"뭔데요??","shushuF_12")
        Talk(name,"먹을거 사오셨어요?","shushuF_12")
        Talk(name,"아니면... 장난감 같은거?","shushuF_12")
    elseif selection==1 then
        Talk(name,"엇","shushuF_12")
        Talk(name,"핸드폰?","shushuF_12")
    elseif selection==2 then
       
        repeat
            Talk("나","가위...바위.....","shushuF_12")
            local selection2 = MakeSelect("나","보!", "shushuF_12", {"가위를 낸다", "바위를 낸다", "보자기를 낸다"})
            if selection2==0 then
                Talk("","내가 이겼다","shushuF_12")
                Talk(name,"아....","shushuF_12")
                Talk(name,"다시해요","shushuF_12")
            elseif selection2==1 then
                Talk("","내가 졌다","shushuF_12")
                Talk(name,"훗.. 이겼군... 이제 보상을 주시죠!","shushuF_12")
            elseif selection2==2 then
                Talk("","비겼다","shushuF_12")
                Talk(name,"다시!","shushuF_12")
            end
        until selection2==1

        Talk("나","자 핸드폰","shushuF_12")
        Talk(name,"핸드폰?!","shushuF_12")
        Talk(name,"드디어??!!","shushuF_12")
        Talk("","눈을 빛내며 기뻐하고있다","shushuF_12")
        local selection = MakeSelect("나","...", "shushuF_12", {"다음에 갚아라", "잘 써야해", "너무 늦게 줘서 미안"})
        if selection==0 then
            Talk(name,"네??","shushuF_12")
            Talk(name,"갚으라고요?! 핸드폰을??","shushuF_12")
            Talk(name,"지..진심인가....","shushuF_12")
            Talk("나","당연히 농담","shushuF_12")
            Talk(name,"아","shushuF_12")
            Talk(name,"싫어요","shushuF_12")
            Talk("나","...미안","shushuF_12")
            Talk(name,"그래도 핸드폰 감사해요","shushuF_12")
            Talk(name,"잘 쓸게요 ","shushuF_12")
            Talk(name,"조심히 쓸게요!","shushuF_12")
            Talk(name,"감사해요 엄마/아빠","shushuF_12")
        elseif selection==1 then
            Talk(name,"당연하죠 진짜 아껴쓸게요!","shushuF_12")
            Talk(name,"감사해요 엄마/아빠","shushuF_12")

        elseif selection==2 then
            Talk(name,"전혀요!","shushuF_12")
            Talk(name,"저는 지금까지 한번도 핸드폰 생각 해본 적 없어요","shushuF_12")
            Talk("나","거짓말. 잠꼬대 하는거 봤어","shushuF_12")
            Talk(name,"큼! 흠흠..","shushuF_12")
            Talk(name,"아니라니까 그러네 정말로 흠흠","shushuF_12")
            Talk(name,"아무튼 감사해요 엄마/아빠","shushuF_12")
            
        end

        
    end
    
end)