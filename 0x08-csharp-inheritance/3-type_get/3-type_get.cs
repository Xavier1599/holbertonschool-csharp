using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Text;


class Obj
{
    ///<summary> prints the names of the available properties and methos of obj </summary>
    public static void Print(object myObj)
    {
        Type tt = myObj.GetType();
        TypeInfo t = tt.GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.GetProperties();
        IEnumerable<MethodInfo> mList = t.GetMethods();

        System.Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo p in pList)
        {
            System.Console.WriteLine(p.Name);
        }

        System.Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo m in mList)
        {
            System.Console.WriteLine(m.Name);
        }
    }
}
