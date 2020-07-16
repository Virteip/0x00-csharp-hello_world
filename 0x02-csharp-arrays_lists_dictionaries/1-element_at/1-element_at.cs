using System;

    class Array
    {
        public static int elementAt(int[] array, int index)
	{
		if (index <= array.Length-1 && index >= 0 ){
			return (array[index]);
		} else {
			Console.WriteLine("Index out of range");
			return (-1);
		}
        }
    }

