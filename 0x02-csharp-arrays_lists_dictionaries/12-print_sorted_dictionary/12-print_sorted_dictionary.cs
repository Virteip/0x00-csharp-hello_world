using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict) 
        {
            List<string> keylist = new List<string>();

            foreach(var row in myDict){
                keylist.Add(row.Key);
            }
            keylist.Sort();
            
            for(int i = 0; i < keylist.Count; i++){
                string key = keylist[i];
                Console.WriteLine($"{key}: {myDict[key]}");
            }
        }
    }

