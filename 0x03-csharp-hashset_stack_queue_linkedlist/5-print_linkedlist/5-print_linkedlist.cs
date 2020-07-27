using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
		LinkedList<int> myList = new LinkedList<int>(); 
		while (myList.Count < size){
			Console.WriteLine(myList.Count);
			myList.AddLast(myList.Count);
		}
		return(myList);
    }
}
