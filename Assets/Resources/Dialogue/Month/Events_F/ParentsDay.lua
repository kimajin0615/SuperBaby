
ParentsDay = CreateDialog(function ()


    name = "슈슈"

    Talk("나","(오늘은 평범하게 따사로운 햇빛이 방 안으로 스며드는 맑은 날의 아침...)","None")
    Talk("","쾅!!!!!","None")
    Talk("나","무슨일이지?!","None")
    Talk(name,"안녕히주무셨어요","shushuF_5")
    local selection =MakeSelect("나","(문짝이 너덜거린다...)", "shushuF_5", {"문이... 문이....", "아침부터 참.. 강력하구나", "대체 이게 무슨.. 어... 무슨일이니....?"})
        if selection==0 then
            Talk(name,"그런건 중요하지 않아요","shushuF_5")
        elseif selection==1 then
            Talk(name,"오늘은 좋은 날이니까요","shushuF_5")
            Talk(name,"어쨋거나 그런건 중요하지 않아요","shushuF_5")
        elseif selection==2 then
            Talk(name,"음!","shushuF_5")
        end

    Talk(name,"이거 받으세요 엄마/아빠","shushuF_5")
    local selection =MakeSelect("나","(이게 뭐지)", "shushuF_5", {"선물을 풀어본다", "선물을 보관한다", "뭐냐고 물어본다"})
        if selection==0 then
            Talk("나","(선물을 풀었다)","shushuF_5")
            Talk("","거대 알 등장.","shushuF_5")
        elseif selection==1 then
            Talk("나","고..고마워~~","shushuF_5")
            Talk("나","(선물을 수납장 위에 올려놓으려는 순간)","shushuF_5")
            Talk(name,"안열어보세요?","shushuF_5")
            Talk("나","나중에 열어보려고..ㅎㅎ","shushuF_5")
            Talk(name,"열어보세요!","shushuF_8")
            Talk("나","나.. 나중에~","shushuF_8")
            Talk(name,"열어보세요!","shushuF_8")
            Talk("나","응..","shushuF_8")
            Talk("나","(선물을 풀었다)","shushuF_8")
            Talk("","거대 알 등장.","shushuF_5")

        elseif selection==2 then
            Talk("나","이게 뭐야?","shushuF_8")
            Talk(name,"선물이요","shushuF_8")
            Talk("나","그니까 뭐가 들었어...?","shushuF_8")
            Talk(name,"직접 확인해보세요","shushuF_8")
            Talk("나","응..","shushuF_8")
            Talk("나","(선물을 풀었다)","shushuF_8")
            Talk("","거대 알 등장.","shushuF_5")

        end
    Talk("나","이게 뭐지...?","shushuF_8")
    Talk("나","(엄청난 크기의... 알?)","shushuF_8")
    Talk(name,"어때요?","shushuF_8")
    Talk(name,"이번 어버이날을 기념해서 열심히 준비한건데!","shushuF_8")
    Talk("나","이게 뭔데..?","shushuF_8")
    Talk(name,"어... 거대도마뱀 알?","shushuF_8")
    Talk("나","(거대 도마뱀이 이렇게 큰가..)","shushuF_8")
    Talk("나","(알을 뚫어져라 쳐다본다)","shushuF_8")
    Talk("알","(흔들흔들)","shushuF_8")
    Talk("나","???????","shushuF_8")
    Talk(name,"!!!!!!!","shushuF_8")
    Talk("알","(빠직! 빠직!)","shushuF_8")
    Talk("나","(알에 금이 가기 시작했다!!!)","shushuF_8")
    Talk(name,"와!!!","shushuF_8")
    Talk("나","이게 대체 뭔데 이게!!!!","shushuF_8")
    Talk(name,"지구 첫 드래곤의 부화!!!!","shushuF_8")
    Talk("나","드래곤?!","shushuF_8")
    Talk("나","(서둘러서 선물상자를 덮었다)","shushuF_8")
    Talk("나","너 이거 어디서가져왔어!!!!","shushuF_8")
    Talk(name,"어....","shushuF_8")
    Talk(name,"대충 차원이동으로?","shushuF_8")

    local selection =MakeSelect("나","(어떻게 말하지)", "shushuF_8", {"이런거 필요없어!", "당장 돌려놓고 와", "드래곤? 내가 아는 그 드래곤?"})
    if selection==0 or selection==1 then
        Talk(name,"왜..왜여...?","shushuF_8")
        Talk("나","필요도 없고 내가 감당을 못해!","shushuF_8")
        Talk(name,"하..하지만 드래곤인데..","shushuF_8")
        Talk("나","진짜로 감당이.....드래곤은 내가 못버틸거야 아마도","shushuF_8")
        Talk(name,"....","shushuF_8")
    elseif select==2 then
        Talk(name,"네! 그 책이랑 만화에 많이 나오는 그 드래곤!!","shushuF_8")
        Talk(name,"드래곤같은거 좋아하시는 것 같아서 찾아왔어요!","shushuF_8")
        Talk("나","그.. 고마운데 진짜 고마운데...","shushuF_8")
        Talk("나","돌려놓고 오자...","shushuF_8")
        Talk(name,"왜..왜여...?","shushuF_8")
        Talk("나","감당이 안될거야...","shushuF_8")
        Talk(name,"으음...","shushuF_8")
        Talk(name,"해보지도 않고...?","shushuF_8")
        Talk("나","안봐도 비디오...","shushuF_8")
        Talk("나","부화하기 전에 돌려두고 와","shushuF_8")
        Talk(name,"네...","shushuF_8")
        Talk("나","(공룡도 그렇고 드래곤도 그렇고 이걸 어쩐담...)","shushuF_8")
    end

end)