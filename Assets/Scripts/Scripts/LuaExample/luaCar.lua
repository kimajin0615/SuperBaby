luaCar = {
    _speed = 10,
    GetSpeed = function(self)
        return self._speed
    end,
    SetSpeed = function(self,value)
        self._speed = value
    end,
    Drive = function(self)
        print("Driving in ".. self._speed .."!")
    end
}