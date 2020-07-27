using System;
using System.Collections.Generic;

class LList 
{
	public static int Pop(LinkedList<int> myLList)    
    {
 		if (myLList.Count > 0)
    	{
			int saveValue = myLList.First.Value;
      		myLList.RemoveFirst();
			return saveValue;
    	}

		return 0;
    }
}
