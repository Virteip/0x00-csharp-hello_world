using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
		LinkedListNode<int> first = myLList.First;
    	while (first != null){
      		if (first.Value > n){
        		return myLList.AddBefore(first, n);
      		}
      		first = first.Next;
    	}
    	return myLList.AddLast(n);
    }
}
