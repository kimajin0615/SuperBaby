
StudyEnglish = CreateDialog(function ()

   

    Talk("나","(얼마전 직장 상사분께 5살이면 영어 교육을 시작해도 된다더라고 들었다)","shushuF_5")
    Talk("나","(근데 발음 나보다 잘하고 외래어도 다 섞어쓰는데 굳이 싶었지만...)","shushuF_5")
    Talk("나","(그래도 혹시 모르니까 한번 얘기해보기로 했다)","shushuF_5")
    Talk("주인공 이름","무슨일이세요??","shushuF_5")

    local selection = MakeSelect("나","...", "shushuF_5", {"영어 읽고 쓸줄 알아?", "이거 뭐라고 읽게? (바나나라고 적힌 글씨를 가르키며)", "세계시민으로 살아가려면 꼭 필요한 지식을 터득하기 위한 시간을 가져보자"})
    if selection==0 then
        Talk("주인공 이름","네","shushuF_5")
        Talk("나","역시...","shushuF_5")
        Talk("나","한글 공부는 안되는건가","shushuF_5")
    elseif selection==1 then
        Talk("주인공 이름","....? 바나나....??","shushuF_5")
        Talk("주인공 이름","뭔...왜요..?","shushuF_5")
        Talk("나","역시...","")
        Talk("나","영어 공부는 안되는건가","shushuF_5")
    elseif selection==2 then
        Talk("주인공 이름","그게 뭔데요??","shushuF_5")
        Talk("나","영어 공부","")
       
      
    end

    Talk("주인공 이름","쓸데없는...","shushuF_5")
    Talk("주인공 이름","한 3살쯤 되었을 때 이미 다 할 수 있었어요","shushuF_5")
    Talk("주인공 이름","문법도 대충은 알고 있었는데 무슨 영어교육같은걸 하려고...","shushuF_5")
    Talk("주인공 이름","한글이고 영어고 다 필요 없는데...","shushuF_5")
    Talk("주인공 이름","제가 배우고싶은건 있는데 그거 알려주시면 안돼요?","shushuF_5")
    Talk("나","뭔데?","shushuF_5")
    Talk("주인공 이름","중국어요","shushuF_5")
    Talk("나","...","shushuF_5")
    Talk("주인공 이름","중국어에 요즘 관심이 생겨서 그래요","shushuF_5")
    Talk("주인공 이름","중국어 배워두면 앞으로도 좋을거에요","shushuF_5")
    Talk("나","...","shushuF_5")

    local selection = MakeSelect("나","(나는 중국어를 모른다... 어떡하지?)", "shushuF_5", {"못한다", "중국어는 무슨 중국! 불어나 배워라", "나도 모르는데.... 배워올게.."})
    if selection==0 then
        Talk("주인공 이름","해보지도 않고!","shushuF_5")
        Talk("주인공 이름","됐어요 제가 알아서 배울거니까!!","shushuF_5")
    elseif selection==1 then
        Talk("주인공 이름","그런거 관심 없는데..","shushuF_5")
        Talk("주인공 이름","나빠...","shushuF_5")
    elseif selection==2 then
        Talk("주인공 이름","좋아요","shushuF_5")
        Talk("주인공 이름","기대할게요!","shushuF_5")
        Talk("나","(중국어 학원이나 알아볼까...)","shushuF_5")
    end
    
end)