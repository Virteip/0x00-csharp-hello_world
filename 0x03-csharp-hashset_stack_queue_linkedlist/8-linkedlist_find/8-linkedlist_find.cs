using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
	{
        int position = 0;
        foreach (int item in myLList)
        {
            if (item == value)
                return (position);
            position++;
        }
        return (-1);
    }
}
