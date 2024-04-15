
SayBirth = CreateDialog(function ()


    Talk("주인공 이름","출생신고 아 맞다 맞아요 출생신고 해야된다는 말을 안했네요","shushuF_0")
    Talk("주인공 이름","출생신고를 하러 가야해요","shushuF_0")


    local selection = MakeSelect("나","...", "shushuF_0", {"그걸 왜 이제 말하는..?", "그럼 지금 하러 가자", "내새끼가 무적자가 될 순 없다 지금 당장 바로 하러가자"})

    if selection == 0 then
        Talk("주인공 이름","어쩌다보니...?","shushuF_0")
        Talk("주인공 이름","어짜피 어제는 일요일이기도 하고 뭐..","shushuF_0")
        Talk("주인공 이름","까먹은건 똑같잖아요","shushuF_0")
        Talk("주인공 이름","지금 준비해서 가는걸로 하죠","shushuF_0")
        Talk("주인공 이름","뭐가 필요한지는 아세요?","shushuF_0")
    elseif selection ==1 then
        Talk("주인공 이름","그럴까요? 그냥 바로 가면 되는거예요? ","shushuF_0")
        Talk("주인공 이름","뭐 준비해야하는건 없어요?","shushuF_0")
    elseif selection ==2 then
        Talk("주인공 이름","앗","shushuF_0")
        Talk("주인공 이름","좋아요","shushuF_0")
        Talk("주인공 이름","바로 가는거예요?","shushuF_0")
        Talk("주인공 이름","준비물같은건 없을까요?","shushuF_0")
    end
    
    
    local selection =MakeSelect("나","(출생신고를 하려면 뭐가 필요하지...?)", "shushuF_0", {"운전면허증", "아이", "주민센터에 전부 있다"})

    if selection ==0 then
        Talk("주인공 이름","아 신분증이 필요하죠?","shushuF_0")
        Talk("주인공 이름","그럼 신분증 챙겨서 갈까요?","shushuF_0")
        Talk("주인공 이름","혹시 모르니까 인터넷에도 찾아봐요","shushuF_0")
    elseif selection ==1 then
        Talk("주인공 이름","음... 출생증명서만 있으면 상관 없는걸로 알고있는데...","shushuF_0")
        Talk("주인공 이름","한번 찾아볼까요?","shushuF_0")
    elseif selection ==2 then
        Talk("주인공 이름","잘 모르겠으면 인터넷에 찾아보는게 맞겠죠?","shushuF_0")
        Talk("","출생신고에 필요한 준비물을 챙겨서 주민센터로 갔다","shushuF_0")
    end

    Talk("","--- 주민센터 ---","shushuF_0")

    Talk("","(웅성웅성)","shushuF_0")
    Talk("주인공 이름","출생신고서 먼저 쓰죠","shushuF_0")
    Talk("","...","")
    Talk("주인공 이름","써야하는게 엄청 많네요...","shushuF_0")
    Talk("주인공 이름","아 출생일시는...","")
    Talk("나","(출생신고서를 열심히 작성했다..)","shushuF_0")

    Talk("주인공 이름","월요일인데도 사람이 많네요","shushuF_0")
    Talk("주인공 이름","...","shushuF_0")
    Talk("주인공 이름","이거 끝나고 뭐하실거예요?","shushuF_0")
    Talk("","...","shushuF_0")
    Talk("스피커","띵동!","shushuF_0")
    Talk("나","(번호표를 뽑은 얼마 후 우리 번호가 호명되었다..)","shushuF_0")
    Talk("공무원","출생신고서랑 신분증이랑 다 저 주시구요...","shushuF_0")
    Talk("나","네","shushuF_0")
    Talk("주인공 이름","...","shushuF_0")
    Talk("공무원","(타탁 타탁)","shushuF_0")
    Talk("나","(무언가 처리중인 것 같다)","shushuF_0")
    Talk("나","(... 괜히 긴장된다)","shushuF_0")
    Talk("주인공 이름","긴장되네요...","shushuF_0")
    Talk("","...","shushuF_0")
    Talk("공무원","네 되셨어요 여기 신분증이랑 챙겨가세요","shushuF_0")
    Talk("공무원","출생신고까지 다 됐는데 어떠세요?","shushuF_0")

    MakeSelect("나","(현재 심정은?)", "shushuF_0", {"좋은 압박감이다", "감동적이다", "날아갈 것 같다"})
    Talk("공무원","좋네요! 안녕히가세요","shushuF_0")



    Talk("","(밖으로 나왔다)","shushuF_0")
    Talk("주인공 이름","앞으로 등본 떼면 제 이름이 있겠네요","shushuF_0")
    Talk("주인공 이름","이제 진짜 가족인거예요","shushuF_0")
    Talk("주인공 이름","잘 부탁드려요 엄마/아빠","shushuF_0")

    MakeSelect("나","(현재 심정은?)", "shushuF_0", {"나도 잘부탁해 딸/아들", "행복한 가족이 되자", "너는 앞으로 내 하나뿐인 가족이다! 열과 성을 다해 돌보겠다 약속하겠어"})

    Talk("주인공 이름","네","shushuF_0")
    Talk("나","(....앞으로 어떤 일들이 일어날까)","shushuF_0")
    Talk("나","(평범하지 않은 아이를 잘 키울 수 있을까 생각이 든다)","shushuF_0")
    Talk("","날이 저물어간다","shushuF_0")


end)