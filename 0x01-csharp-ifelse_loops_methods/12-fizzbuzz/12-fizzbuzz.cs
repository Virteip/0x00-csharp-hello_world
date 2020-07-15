using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
             for (int number = 1; number <= 99; number++)
            {
                if (number % 15 == 0){
                    	Console.Write("FizzBuzz ");
		    }
                else if (number % 5 == 0){
                     	Console.Write("Buzz ");
		    }
                else if (number % 3 == 0){
                     	Console.Write("Fizz ");
		    }
                else{
			Console.Write("{0} ", number);
		    }
            }
            Console.Write("Buzz");
        }
    }
}
