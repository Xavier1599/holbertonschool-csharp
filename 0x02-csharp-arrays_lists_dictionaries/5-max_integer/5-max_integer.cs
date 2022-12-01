﻿using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int nMax = myList[0];
        foreach (int i in myList)
        {
            if (i > nMax)
            {
                nMax = i;
            }
        }
        return nMax;
    }
}
