using System;

    class Line
    {
        public static void PrintLine(int length)
        {
	    int counter = 1;

	    while (counter <= length){

	    	  Console.Write("_");
		  counter++;
	    }
	    Console.WriteLine();
        }
    }