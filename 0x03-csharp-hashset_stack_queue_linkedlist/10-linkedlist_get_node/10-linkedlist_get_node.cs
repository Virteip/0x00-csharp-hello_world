using System;
using System.Collections.Generic;
class LList 
{
    public static int GetNode(LinkedList<int> myLList, int n)
	{
       	if(n <= myLList.Count){
			int position = 0;
			foreach (int item in myLList)
        	{
            	if (position == n){
                	return (item);
				}
            	position++;
        	}
		}
			return(0);
	 
    }
}
