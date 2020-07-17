using System;

    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
        {   
            int width = myMatrix.GetLength(0);
            int height = myMatrix.GetLength(1);
            int[,] grid = new int[width,height];

            for (int i = 0; i < width; i++){
                for (int j = 0; j < height; j++){
                    grid[i,j] = myMatrix[i, j] * myMatrix[i, j];
                }
            }
            return grid;
        }
    }

