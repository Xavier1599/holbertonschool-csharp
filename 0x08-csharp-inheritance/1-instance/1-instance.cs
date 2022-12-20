using System;
using System.Collections.Generic;

    class Obj
    {
        ///<summary> True if obj is an instance of the array </summary>
        public static bool IsInstanceOfArray(object obj)
        {
            return (typeof(Array).IsInstanceOfType(obj));
        }
    }
