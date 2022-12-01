using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;
        int d = 0;
        while (current != null)
        {
            if (d == index)
            {
                myLList.Remove(current);
            }
            d += 1;
            current = current.Next;
        }
    }
}
