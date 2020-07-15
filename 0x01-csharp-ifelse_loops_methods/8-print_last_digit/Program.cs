using System;

    class Number
    {
        public static int PrintLastDigit(int number)
        {
	    int number_absolute = number % 10 > 0 ? (number % 10) : (number%10 * -1);
            Console.Write("{0}", number_absolute);
	    return (number_absolute);
        }
    }