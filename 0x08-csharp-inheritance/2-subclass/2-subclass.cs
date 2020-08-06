using System;

///<summary>Checks Obj</summary>
class Obj
{
    ///<summary>Is it a subclass</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
