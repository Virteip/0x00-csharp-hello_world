﻿using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> DeleteAt(List<int> myList, int index)
        {
            if (index <= myList.Count - 1){
                myList.Remove(myList[index]);
                return myList;
            }else{
                Console.WriteLine("Index is out of range");
                return myList;
            }
        }
    }

