using System;

class Int 
{
    public static void divide(int a, int b)
    {
		int div = 0;
		try{
			div = a / b;
		}
		catch (Exception){
			Console.WriteLine("Cannot divide by zero");
		}
		finally {
			Console.WriteLine($"{a} / {b} = {div}");
		}
    }
}
