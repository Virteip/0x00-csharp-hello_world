using System;

///<summary>Checks Obj</summary>
class Obj
{
    ///<summary>Is it an instance of int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
