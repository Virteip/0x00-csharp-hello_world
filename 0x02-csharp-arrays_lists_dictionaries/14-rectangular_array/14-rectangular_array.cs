using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[5,5];
            grid[2,2] = 1;

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                    Console.Write(grid[i,j]);
                    if(j != 5 - 1){
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
