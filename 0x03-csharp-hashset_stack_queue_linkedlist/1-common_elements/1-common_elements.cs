using System;
using System.Collections.Generic;

class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();
        foreach (int item in list2){
          	if(list1.Contains(item)){
				newList.Add(item);
			}
		}

		return newList;
    }
}
