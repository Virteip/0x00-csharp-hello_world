using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
		int indx;
		List<int> newList = new List<int>();
		int result;
		for(indx = 0; indx < listLength; indx++){
			result = 0;
			try{	
				result = list1[indx]/list2[indx];
				newList.Add(result);
			} catch (DivideByZeroException) {
				Console.WriteLine("Cannot divide by zero");
				newList.Add(result);
			} catch (ArgumentOutOfRangeException) {
				Console.WriteLine("Out of range");
			}
		}
		return (newList);
    }
}
