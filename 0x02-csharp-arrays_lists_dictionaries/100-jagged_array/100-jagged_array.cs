using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
             int [][] grid = new int[3][];
	         grid[0] = new int[4]{0, 1, 2, 3};
	         grid[1] = new int[7]{0, 1, 2, 3, 4, 5, 6};
	         grid[2] = new int[2]{0, 1};

             for (int x = 0; x < grid.Length; x++)
	         {
	            for (int y = 0; y < grid[x].Length; y++)
	                
                    if (y < grid[x].Length - 1){
	    	            Console.Write($"{grid[x][y]} ");
                    } else {
		                Console.WriteLine($"{grid[x][y]}");
                    }

             }
        }

    }
}

