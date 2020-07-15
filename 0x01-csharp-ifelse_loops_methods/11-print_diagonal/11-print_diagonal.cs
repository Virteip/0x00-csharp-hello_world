using System;

    class Line
    {
        public static void PrintDiagonal(int length)
        {
           for (int row = 0; row < length; row++)
           {
		 for (int space = 0; space < row; space++){
                     	  Console.Write(" ");
		 }
            	 Console.WriteLine("\\");
           }
		Console.WriteLine("");
        }
    }
