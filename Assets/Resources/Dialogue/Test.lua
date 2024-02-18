

Test = CreateDialog(function()
    Talk("","테스트용 문장",null)
    Talk("이름"    ,    "대사"    ,    "이미지")
    local select = MakeSelect("미친아진","김수연 루아 시킬까?","TestImage",{"무슨소리! 무조건 시키자","당연히 시킨다"})
end)