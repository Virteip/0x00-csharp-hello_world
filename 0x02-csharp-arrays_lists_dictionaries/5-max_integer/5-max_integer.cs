﻿using System;
using System.Collections.Generic;

    class List
    {
        public static int MaxInteger(List<int> myList)
	    {
            if(myList.Count > 0){
                myList.Sort();
                int last = myList.Count - 1;

	   	        return myList[last];
	        } else {
                Console.WriteLine("List is empty");
                return -1;
            }
        }
    }
