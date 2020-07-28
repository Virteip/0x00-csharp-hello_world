using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {	
		int position = 0;

		try{
			while(position <= n){
				Console.WriteLine(myList[position]);
				position++;
			}
		} catch (Exception) {
			return position;	
		}

		return position;
    }
}
