using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size >= 0){
	       int[] array = new int[size];
	       for (int i = 0; i < size; i++){
	       	   array[i] = i;
		   Console.Write($"{array[i]} ");
	       }
	       Console.WriteLine();
	       return (array);
	    } else {
		Console.WriteLine("Size cannot be negative");
		return (null);
	    }
        }
   }
