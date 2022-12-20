using System;

class Obj
{
    ///<summary> True if the obj is an instance of a class </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
