using System;
using System.Collections.Generic;

class Obj
{
    ///<summary> Returns the obj if is TRUE</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
    }
}
