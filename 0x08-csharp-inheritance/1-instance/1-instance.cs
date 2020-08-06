
using System;

///<summary>Checks Obj</summary>
class Obj
{
    ///<summary>Is it an instance of array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
