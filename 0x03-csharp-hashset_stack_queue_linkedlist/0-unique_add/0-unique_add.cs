using System;
using System.Collections.Generic;

class List 
{
    public static int Sum(List<int> myList)
    {
		HashSet<int> unique = new HashSet<int>(myList);
		int result = 0;
		foreach(var key in unique)
		{
   			result += key;
		}
		return(result);
    }
}
