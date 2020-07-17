using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            int max = 0;
            string name = null;
            foreach(KeyValuePair<string, int> pair in myList){
                    if(max < pair.Value){
                        max = pair.Value;
                        name = pair.Key;
                    }
            }
            return name;
        }
    }

