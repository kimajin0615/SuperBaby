
PromotionParty = CreateDialog(function ()


    name = "슈슈"

    Talk("문","삐삐비비삑비빆!!! 삐리링!!","None")
    Talk(name,"다녀오셨어요","shushuF_12")
    local selection = MakeSelect("나","...", "shushuF_12", {"우와!!!!!!!", "다녀왔어"})
    if selection==0 then
        Talk("나","우와아아아악!","shushuF_12")
        Talk(name,"무 무슨!","shushuF_12")
        Talk("나","승진했다!!","shushuF_12")
        Talk(name,"승진..?","shushuF_12")
        Talk("나","승진!!!!!","shushuF_12")
        Talk(name,"오... 축하해요","shushuF_12")
    elseif selection==1 then
        Talk("나","오늘 별 일 없었지?","shushuF_12")
        Talk(name,"저는 별 일 없었는데","shushuF_12")
        Talk(name,"엄마/아빠는요?","shushuF_12")
        Talk("나","나? 왜? 별 일 있어보여?","shushuF_12")
        Talk(name,"네, 평소보다 60퍼센트 쯤 더 기뻐보이는데...","shushuF_12")
        Talk("나","그래? 어떻게알았지??","shushuF_12")
        Talk("나","사실 승진했어","shushuF_12")
        Talk(name,"오... 축하해요","shushuF_12")
        local selection2 = MakeSelect("나","...", "shushuF_12", {"반응 구려", "뭐야 안기뻐?", "우리 집 가장의 금전적 소득이 늘었건만 반응이 그거밖에 안되나?"})
        if selection2==0 then
            Talk(name,"사실 알고있었으니까..","shushuF_12")
            Talk(name,"딱히 놀랄 수가 없는거죠","shushuF_12")
        elseif selection2==1 then
            Talk(name,"기쁘긴 한데...","shushuF_12")
            Talk(name,"한 5시간 전에 한참 기뻐하고 지금은 진정했어요","shushuF_12")
            Talk("나","5시간 전에??","shushuF_12")
        elseif selection2==2 then
            Talk(name,"아니 물론 기쁘죠","shushuF_12")
            Talk(name,"근데 이미 기뻐할거 다 기뻐했는데 어떡해요","shushuF_12")
            Talk("나","기뻐할거 다 기뻐했다고?","shushuF_12")
        end
        Talk("나","어떻게?","shushuF_12")
        Talk(name,"예지? 텔레파시? 뭐 아무튼간에 번쩍! 하고 깨닳았다고 해야하나","shushuF_12")
        Talk("나","어떻게..?","shushuF_12")
        Talk(name,"저도 모르죠!! 얼마 전부터 이랬어요","shushuF_12")
        Talk(name,"다른사람 생각도 들리는데.. 좀 예의 아니니까 안들을라고 엄청 노력하고있고..","shushuF_12")
        Talk("나","갈수록 뭐가.. 막 생기네","shushuF_12")
        Talk(name,"아무튼간에 승진 기념으로 선물 준비했어요","shushuF_12")
        Talk(name,"여기요 열어보세요","shushuF_12")

        local selection2 = MakeSelect("나","...", "shushuF_12", {"상장", "케이크", "장신구"})
        if selection2==0 then
            Talk("나","상장..?","shushuF_12")
            Talk(name,"제가 우리 어머니/아버지를 위해 준비한 상장과 꽃다발입니다","shushuF_12")
            local selection3 = MakeSelect("나","...", "shushuF_12", {"감동이다", "쓸모없다", "으...으응 고맙다..^^...."})
            if selection3==0 then
                Talk(name,"ㄱㅡ래도 나름 열심히 만든거니까요","shushuF_12")
            elseif selection3==1 then
                Talk(name,"?? 그럼 받지 마세요","shushuF_12")
                Talk(name,"괜한걸 준비했네..","shushuF_12")
                Talk("나","아냐!! 농담이지","shushuF_12")
            elseif selection3==2 then
                Talk(name,"흠","shushuF_12")
                Talk(name,"자 일단 꽃다발 받으시고","shushuF_12")
                Talk(name,"상장 수여식이 있겠습니다","shushuF_12")
                Talk("나","와~","shushuF_12")
                Talk(name,"상장,","shushuF_12")
                Talk(name,"위 사람은  과거부터 현재까지 좋은 부모로 있어 주었기에 이 상을 수여함","shushuF_12")
                Talk(name,"축하드립니다","shushuF_12")
                Talk("나","와 감사합니다","shushuF_12")
                Talk(name,"앞으로도 잘 부탁드릴게요 엄마/아빠","shushuF_12")
                Talk("나","(앞으로도 더 자랑스러운 부모가 될 수 있게 노력하자)","shushuF_12")
            end
        elseif selection2==1 then
            Talk("나","케이크?? 사온거야?","shushuF_12")
            Talk(name,"설마 이런 큰 일에 쓸 케이크를 사왔을까요","shushuF_12")
            Talk(name,"직접 만들었죠","shushuF_12")
            local selection3 = MakeSelect("나","(직접 만들었다고?)", "shushuF_12", {"맛있을까?", "와 설마! 거짓말이지?", "진짜 감동이야 고마워"})
            if selection3==0 then
                Talk(name,"제가 만든건데 맛이 없을리가요","shushuF_12")
                Talk("나","하긴 그렇긴 해","shushuF_12")
                Talk("나","우리집 요리도 거의 네가 만드는거니까...","shushuF_12")
                Talk(name,"하여튼간에 진짜 맛있을거에요","shushuF_12")
                Talk(name,"엄마/아빠가 좋아하는 맛으로 특별히 만든거니까","shushuF_12")
            elseif selection3==1 then
                Talk(name,"아무튼 엄청 맛있을거에요","shushuF_12")
                Talk(name,"엄마/아빠가 좋아하는 맛으로 특별히 만든거니까","shushuF_12")
            elseif selection3==2 then
                Talk(name,"헤헤","shushuF_12")
                Talk("나","(쑥스러워한다)","shushuF_12")
                Talk(name,"ㅇ.. 여튼간에 진짜 맛있을거에요!","shushuF_12")
                Talk(name,"엄마/아빠가 좋아하는 맛으로 특별히 만든거니까","shushuF_12")
               
            end
            Talk(name,"자 드셔보세요!","shushuF_12")
            Talk("나","(맛있어보이는 딸기 생크림 케이크...)","shushuF_12")
            Talk("나","(커다란 홀케이크를 칼로 갈라서 한 조각을 접시에 덜어냈다...)","shushuF_12")
            Talk("나","(포크로 케이크 조각을 찔러서 떠냈다...)","shushuF_12")
            Talk("나","(달달해보이는 크림과 빵 그 중간에 껴있는 새콤달콤한 딸기...)","shushuF_12")
            Talk("나","(한 입에 집어삼켰다!)","shushuF_12")
            Talk("나","(매우 맛있다!!! 많이 달아보인 것 과는 다르게 과하게 달지 않아 단걸 못먹는 사람이라도 먹을 수 있을 것 같다)","shushuF_12")
            Talk("나","(적당한 크림의 양! 폭신부들한 빵! 너무 단맛만 느껴지지 않게 해주는 딸기!)","shushuF_12")
            Talk("나","(美味...)","shushuF_12")
            Talk("나","완벽해....","shushuF_12")
            Talk(name,"당연하죠","shushuF_12")
            Talk("나","(나를 위해 이런 케이크를 굽는 모습을 상상하니 눈물이 차오른다)","shushuF_12")
            Talk("나","(맛있기도 하고)","shushuF_12")
            Talk("나","마히다...","shushuF_12")
            Talk(name,"엄마/아빠 울어요?!","shushuF_12")
            Talk("나","마히허....ㅠㅠ","shushuF_12")
            Talk(name,"아니 그렇다고 울것까지야 있나...??","shushuF_12")
            Talk(name,"진..진정하시고...","shushuF_12")
            Talk("나","(앞으로도 이런 일상을 보낼 수 있게 더 노력하자...)","shushuF_12")
        
        elseif selection2==2 then
            local selection3 = MakeSelect("나","(조금 비싸보이는...)", "shushuF_12", {"반지", "팔찌"})
                if selection3==0 then
                    Talk("나","헉 이런걸 어디서 사온거야","shushuF_12")
                    Talk("나","돈은 있었어??","shushuF_12")
                    Talk(name,"돈이야 뭐 모으면 있는거고","shushuF_12")
                    Talk(name,"훔친건 아니니까 걱정하지 마세요","shushuF_12")
                    Talk("나","근데 왜 반지를?","shushuF_12")
                    Talk(name,"아 아니... 그 엄마/아빠 미혼인데 나 키우고 있는거니까....","shushuF_12")
                    Talk(name,"엄마/아빠 외모만 보고 치근대는 사람 없으면 좋겠고..","shushuF_12")
                    Talk(name,"그런 사람한테 속아서 우리 가족구성원에 그런 사람이 추가되는건 더 싫으니까..","shushuF_12")
                    Talk(name,"아 물론 진짜 엄마가 원하면 막지는 않을게요","shushuF_12")
                    Talk(name,"근데 저한테 허락은 받으셔야해요","shushuF_12")
                    Talk("나","(그런 생각을 하고 있었구나...)","shushuF_12")
                    Talk("나","(근데...)","shushuF_12")
                    Talk("나","너 키운다고 바빠서 그런 생각은 꿈도 못꾸는거 알아?","shushuF_12")
                    Talk(name,"앗","shushuF_12")
                    Talk(name,"그치만","shushuF_12")
                    Talk("나","고마워 앞으로 끼고 다닐게","shushuF_12")
                    Talk(name,"네 꼭 끼고다니세요","shushuF_12")
                    Talk("나","(묘한 독점욕일까? 앞으로도 평화로운 생활을 하고싶다는 것 아닐까. 그 꿈을 지킬 수 있게 노력하자)","shushuF_12")
                elseif selection3==1 then
                    Talk("나","헉 이런걸 어디서 사온거야","shushuF_12")
                    Talk("나","돈은 있었어??","shushuF_12")
                    Talk(name,"돈이야 뭐 모으면 있는거고","shushuF_12")
                    Talk(name,"훔친건 아니니까 걱정하지 마세요","shushuF_12")
                    Talk("나","근데 왜 팔찌?","shushuF_12")
                    Talk(name,"사실 그 장신구를 사러 갔는데","shushuF_12")
                    Talk(name,"뭘 사야할지 고민이 돼서 좀 서성거리고 있었더니","shushuF_12")
                    Talk(name,"점원이 다가와서","shushuF_12")
                    Talk(name,"애인에게 선물하려는데 반지는 부담된다면 팔찌가 제격!'","shushuF_12")
                    Talk(name,"이라면서 엄청 추천해주길래","shushuF_12")
                    Talk(name,"기세에 못이겨서 사온거죠 뭐","shushuF_12")
                    Talk("나","음","shushuF_12")
                    Talk(name,"그리고 반지나 목걸이같은건 하고 다니기 귀찮을테니까","shushuF_12")
                    Talk(name,"팔찌가 제일 낫지 않나 싶어서 그런거죠","shushuF_12")
                    Talk("나","(팔찌가 반짝반짝 빛난다 여러가지 색의 보석 혹은 큐빅이 서로 어울려 한가지 빛으로 빛나고있다)","shushuF_12")
                    Talk("나","(분명 오랫동안 그 자리에 서서 고민했을 것이다)","shushuF_12")
                    Talk("나","(따듯한 마음이 전해지는 듯 한 팔찌다)","shushuF_12")
                end
                Talk(name,"마음에 들어요?","shushuF_12")
                local selection3 = MakeSelect("나","...", "shushuF_12", {"응", "아니"})
                if selection3==0 then
                    Talk("나","당연하지 죽을때까지 하고 다닐게","shushuF_12")
                    Talk("나","고마워","shushuF_12")
                    Talk("나","(이 따듯한 마음이 내가 죽고 나서도 그 온도가 유지 될 수 있게 하고 싶다)","shushuF_12")
                    Talk("나","(더욱 노력해야지)","shushuF_12")
                elseif selection3==1 then
                    Talk("나","좀 센스 구린거같은데?","shushuF_12")
                    Talk(name,"ㅅ.. 싫으면 다시 돌려주세요!","shushuF_12")
                    Talk("나","아니! 농담이야 절대로 안돌려줄거지롱","shushuF_12")
                    Talk(name,"!","shushuF_12")
                    Talk("나","죽을때까지 하고 다닐게","shushuF_12")
                    Talk("나","고마워","shushuF_12")
                    Talk("나","(이 따듯한 마음이 내가 죽고 나서도 그 온도가 유지 될 수 있게 하고 싶다)","shushuF_12")
                    Talk("나","(더욱 노력해야지)","shushuF_12")
                end
        end


    end


    
    
end)