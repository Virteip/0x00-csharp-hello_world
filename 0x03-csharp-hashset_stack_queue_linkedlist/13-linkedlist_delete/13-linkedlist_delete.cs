using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> node = myLList.First;
        for (int ind = 0; ind < index && node.Next != null; ind++){
            node = node.Next;
        	if (ind == index){
            	myLList.Remove(node);
			}
		}
    }
}
