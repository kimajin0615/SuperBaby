
ElementarySchool= CreateDialog(function ()

    name = "슈슈"

    
    Talk(name,"저기 엄마/아빠","shushuF_8")
    Talk(name,"저 곧 초등학교 입학하는데 준비물같은건 언제 사러가요?","shushuF_8")
    Talk("나","아 맞다","shushuF_8")
    Talk(name,"까먹으셨어요?","shushuF_8")
    local selection = MakeSelect("나", "(어떡하지)", "shushuF_8", {"말 나온김에 지금 하러 가자", "오늘 하러 갈 계획이였음ㅎㅎ", "아 미안 지금이라도 하러갈까?"})
    if selection==0 then
        Talk(name,"...","shushuF_8")
        Talk(name,"어휴","shushuF_8")
        Talk(name,"내일되면 또 까먹을거같은데 바로 하러 가요","shushuF_8")
    elseif selection==1 then
        Talk(name,"..........","shushuF_8")
        Talk(name,"네","shushuF_8")
    elseif selection==2 then
        Talk(name,"괜찮아요 그럴 수 있죠","shushuF_8")
        Talk(name,"음","shushuF_8")
        Talk("나","그럼 준비하고 바로 가자","shushuF_8")
    end
    

    Talk("", "--- 마트 ---","None")
    
    Talk(name,"뭐 사야하는지 알아요?","shushuF_8")
    local selection = MakeSelect("나", "(뭘 사야하더라)", "shushuF_8", {"가방", "필기구", "장난감"})
        if selection==0 then
            Talk(name,"가방 집에 하나 있기는 한데","shushuF_8")
            Talk(name,"저는 새거 하나 갖고싶었어요!","shushuF_8")
            Talk(name,"새 가방 좋아요 히히","shushuF_8`")
        elseif selection==1 then
            Talk(name,"공책이랑 연필이랑 색연필이랑 가위랑 풀이랑....","shushuF_8")
            Talk(name,"뭐이렇게 필요한게 많대요?","shushuF_8")
            Talk(name,"초등학교에서는 대체 뭘 하길래?!","shushuF_8")
            Talk(name,"으음... 궁금해지네요","shushuF_8")
        elseif selection==2 then
            Talk(name,"보통 학교에 장난감을 가져가지는 않지 않나요?","shushuF_8")
            Talk(name,"하지만","shushuF_8")
            Talk(name,"장난감 사주신다면 저야 감사하죠 아싸!","shushuF_8")
        end
    Talk("나","또 뭐가 필요하려나...","shushuF_8")
    Talk("나","(네글에 초등학교 준비물을 검색해봤다)","shushuF_8")
    Talk("나","(책가방 실내화 색연필 사인펜 세트 크래파스 필통 연필 지우개 연필깎이 가위 풀 색종이 모형자 종합장 스케치북)","shushuF_8")
    Talk("나","(책가방 실내화 색연필 사인펜 세트 크래파스 필통 연필 지우개 연필깎이 가위 풀 색종이 모형자 종합장 스케치북)","shushuF_8")
    Talk("나","필요한게 왜이렇게 많아?!","shushuF_8")
    Talk("","(양손가득 준비물을 구매했다...)","shushuF_8")
    Talk("나","지금 심정이 어떠시죠 아드님/따님","shushuF_8")
    Talk(name,"엄청... 기대되네요...","shushuF_8")
    Talk(name,"뭔가 두근거려요","shushuF_8")
    local selection = MakeSelect("나", "...", "shushuF_8", {"재밌을거야", "엄청 힘들걸?", "좋은 경험이 될거야"})
    if selection==0 then
        Talk(name,"그럼요","shushuF_8")
    elseif selection==1 then
        Talk(name,"힘들어도 분명 즐거울 것 같아요","shushuF_8")
    elseif selection==2 then
        Talk(name,"네..!","shushuF_8")
    end

end)