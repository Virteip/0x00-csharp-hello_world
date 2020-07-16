using System;

    class Array
    {
           public static void Reverse(int[] array)
	   {
	      if (array != null){
        	for (int point = array.Length - 1; point >= 0; point--) {
			Console.Write($"{array[point]}");
			if (point != array.Length-1){
				Console.Write(" ");
		   	}
           	}
              }
	      Console.WriteLine();
    	   }
    }

