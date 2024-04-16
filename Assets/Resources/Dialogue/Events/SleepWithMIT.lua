
SleepWithMIT = CreateDialog(function ()

    Talk("나","(슬슬 자려고 준비중이다...)","shushuF_3")
    Talk("","똑똑","shushuF_3")
    Talk("나","?","shushuF_3")
    Talk("나","(방 문에서 노크하는 소리가 들린다)","shushuF_3")
    Talk("주인공 이름","저 들어가도 되나요","shushuF_3")

    local selection = MakeSelect("나","어떡하지", "shushuF_3", {"들어오라고 한다", "자는척한다"})
    if selection==0 then
        Talk("나","무슨일이야? 들어와","shushuF_3")
        Talk("주인공 이름","주무시는 줄 알았어요","shushuF_3")
        Talk("나","응? 아냐아냐 아직 안자 근데 어쩐일로?","shushuF_3")
        Talk("주인공 이름","그... 자기전에 읽어줬으면 좋겠는게 있어서....","shushuF_3")
        Talk("주인공 이름","혹시 해주실 수 있나요...?","shushuF_3")
        local selection2 = MakeSelect("나","(동화책을 읽어달라는 것일까? 해줘야하나...?)", "shushuF_3", {"음 그래그래 뭐읽어줄까?", "내가 성대결절이 있어서 좀 힘들듯...", "오늘은 시간이 좀 늦어서 내일 해줄게"})
        if selection2==0 then
            Talk("나","읽어줬으면 좋겠는 동화책 있어?","shushuF_3")
            Talk("주인공 이름","네..? 동화책이요...?","shushuF_3")
            Talk("주인공 이름","그런건 됐고... 이거 읽어주세요","shushuF_3")
            Talk("나","(종이 뭉치를 하나 건네받았다)","shushuF_3")
            Talk("나","...","shushuF_3")
            Talk("나","티라노사우루스 이동 속도와 사냥에 대한 고찰","shushuF_3")
            Talk("나","논문...?","shushuF_3")
            Talk("주인공 이름","(눈을 반짝반짝 빛내고있다)","shushuF_3")
            Talk("나","...","shushuF_3")
            Talk("나","티라노사우루스는 현재까지 50여 군집체가 발견되었으며, 수각류이고 육식공룡이다. 당시 많은 수각류가 있었으나...","shushuF_3")
            Talk("나","티라노사우루스는 가장 많은 학설과 의문을 가지고 있는 공룡 중 하나이다...","shushuF_3")
            Talk("나","티라노사우루스의 논란은 이동속도와 극히 짧은 앞다리, 그리고 타 수각류와 다소 다른 이빨 형태와 관련되는데,,,","shushuF_3")
            Talk("나","이것들은 사냥방법을 추정하는 데 매우 중요하다. 첫 번째, 뼈의 형태학적 구성으로 볼 때,,,","shushuF_3")
            Talk("나","티라노사우루스의 이동속도는 약 시속 20km로 추정되는데,,,","shushuF_3")
            Talk("나","이 속도는 사냥을 하기에 적합하지 않은 것으로 보인다...","shushuF_3")
            Talk("나","(논문을 열심히 읽었다...)","shushuF_3")
            Talk("주인공 이름","(쿨쿨 새근새근)","shushuF_3")
            Talk("나","(논문 내용이 재밌었는지 웃으면서 자고있다)","shushuF_3")
            Talk("나","(티라노... 20km... 느린것 같다..)","shushuF_3")
            Talk("나","(어쨋든 오늘 하루도 즐겁게 마무리 되었다)","shushuF_3")

        elseif selection2==1 or selection2==2  then
            Talk("주인공 이름","앗...네...","shushuF_3")
            Talk("주인공 이름","알겠습니다 주무세요...","shushuF_3")
        end
    elseif selection==1 then
        Talk("주인공 이름","앗 주무시나보네...","shushuF_3")
        Talk("주인공 이름","오늘은 안되겠다 방 가야지...","shushuF_3")
        
    end



    
end)