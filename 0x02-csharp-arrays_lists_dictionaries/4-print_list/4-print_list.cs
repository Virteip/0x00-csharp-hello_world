using System;
using System.Collections.Generic;
    class List 
    {
        public static List<int> CreatePrint(int size)
	{
            if (size < 0){
		Console.WriteLine("Size cannot be negative");
		return (null);
	    } else {
	    	List<int> lista = new List<int>();
		for (int nums = 0; nums <= size - 1; nums++){
			lista.Add(nums);
			if (nums == size - 1){
			    Console.Write($"{nums}");
			    break;
			}
			Console.Write($"{nums} ");
		}
		Console.Write("\n");
	    	return(lista);
	    }
        }
    }
