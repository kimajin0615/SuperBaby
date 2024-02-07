LuaLua = CreateDialog(function()

    Talk("Test","테스트","TestImage")

    local Choice = MakeSelect("Test","선택지를 고르자","TestImage",{"선택지1","선택지2"})
    if Choice == 0 then
        Talk("Test","선택지1을 고르셨습니다","TestImage")
    
    else
        Talk("Test","선택지1을 고르셨습니다","TestImage")
    end

    Talk("Test","테스트 끝","TestImage")


end)