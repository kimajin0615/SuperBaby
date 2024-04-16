
Dinosaur = CreateDialog(function ()

    name = "슈슈"

    Talk("나","(오늘은 평범한 1월 1일...)","None")
    Talk("나","(햇살이 따듯해서 눈을 뜨기 싫은 날이였다.....)","None")
    Talk("??","크웡","None")
    Talk("나","??","None")
    Talk(name,"아냐 그러면 안돼 이리와","shushuF_3")
    Talk("??","크웡","None")
    Talk("나","??","None")
    Talk("나","(내 눈꺼풀 밖에서 무슨일이 일어나고 있는거지?)","None")

    

    repeat
        local selection = MakeSelect("나","(확인해봐야할까..?)", "None", {"꾹 닫고 모른척", "눈을 뜬다"})
        if selection==0 or selection==1 then
            Talk("나","(잠결에 잘못 들은게 분명해... 다시 자자)","None")
            Talk("??","크워엉","None")
            Talk(name,"그럼 안된다니까! 이리와!!","shushuF_3")
            Talk("나","???","None")
        end
        
    until selection==2
        
    Talk("나","(조심스럽게 눈을 떴다)","None")

    Talk("","공룡 등장.","None")

    Talk("공룡","크워어","None")
    Talk("나","???????????????????????","None")
    Talk(name,"앗!!","shushuF_3")
    Talk(name,"아 정말! 그러지 않기로 했잖아!","shushuF_3")
    Talk(name,"들키면 다시 돌아가야한다니까","shushuF_3")
    Talk("나","이.. 이게 무슨상황이야..?","shushuF_3")
    Talk(name,"으악 결국에!!!!!","")
    Talk(name,"그 그게요 얘는 크왕이라고 하는데 아침에 잠깐 나갔다가 길거리에 버려져있길레 제가 데려온건데...!","shushuF_3")
    MakeSelect("나","어...??", "shushuF_3", {"공룡을...???", "크왕이...???", "길바닥에서...???"})

    Talk(name,"진짜예요!!","shushuF_3")
    Talk("나","(진짤까...?)","shushuF_3")
    Talk(name,"지..진짜!","shushuF_3")

    local selection =MakeSelect("나","...", "shushuF_3", {"객관적으로 21세기에 공룡을 길바닥에서 줍는다는건 말도 안돼", "진짜로...........?", "안혼낼테니까 사실대로 말해"})
        if selection==0 then
            Talk(name,"맞는 말이지만 제 말이 맞아요","shushuF_3")
        elseif selection==1 then
            Talk(name,"진짜예요","shushuF_3")
        elseif selection==2 then
            Talk(name,"저...정말로!","shushuF_3")
        end

    Talk(name,"21세기에도 뭐 공룡이 있을수도 있으니까요","shushuF_3")
    Talk(name,"빙하타고 떠내려왔겠죠 ","shushuF_3")
    Talk(name,"아니면 공룡이 아니라 사실 유전자 혼합된 새로운 생물종일수도 있고.....","shushuF_3")
    Talk("나","(아무리 생각해도 거짓말을 하는것 같다...)","shushuF_3")
    Talk("나","....흠","shushuF_3")
    Talk(name,"....!!","shushuF_3")
    Talk("나","흐음......","shushuF_3")
    Talk(name,"........!!","shushuF_3")
    Talk(name,"죄송해요","shushuF_3")
    Talk(name,"사실 제가 데려온거예요...","shushuF_3")
    Talk(name,"공룡이 실제로 너무 보고싶어서 과거로 갔는데...","shushuF_3")
    Talk(name,"크왕이가 저를 너무 이쁘게 쳐다보고 그래가지고....","shushuF_3")
    Talk(name,"분명 저랑 같이 지내고싶어하는 눈빛이였어요","shushuF_3")
    Talk(name,"그래서 그 같이 온건데... 크왕이...","shushuF_3")
    Talk("크왕이","크왕왕","shushuF_3")
    Talk(name,"크왕아....!","shushuF_3")
    Talk("나","(가련하다)","shushuF_3")
    Talk(name,"앞으로 크왕이랑 같이 지내면 안되나요","shushuF_3")
    Talk(name,"제가 잘 챙길게요","shushuF_3")
    Talk(name,"산책도 잘 시키고 밥도 잘 주고 자주 씻겨주고!!!","shushuF_3")

    local selection =MakeSelect("나","(어떡하지....)", "shushuF_3", {"크왕이는.. 21세기 대한민국 20평대 아파트에선 살 수 없어", "크왕이 가족들이 크왕이를 기다릴거야", "가끔 보러가는걸로 하는건 어때?"})
        if selection==0 then
            Talk(name,"맞지만 그치만","shushuF_3")
            Talk(name,"....","shushuF_3")
            Talk(name,"알았어요... 다시 데려다주고 올게요...","shushuF_3")
        elseif selection==1 then
            Talk(name,"크왕이 가족...? 거기에 없었는데...","shushuF_3")
            Talk("나","다른곳에 갔다오는 길이라던가, 길을 잃어서 크왕이를 놓친걸거야","shushuF_3")
            Talk(name,"...","")
            Talk(name,"알았어요... 다시 데려다주고 올게요...","shushuF_3")
        elseif selection==2 then
            Talk(name,"하지만 크왕이랑 같이 지내는게 좋은데..","shushuF_3")
            Talk(name,"...","")
            Talk(name,"알았어요... 다시 데려다주고 올게요...","shushuF_3") 
        end
    Talk("","그렇게 크왕이는 다시 기원전 몇만년 전으로 돌아갔다","shushuF_3")
    
end)