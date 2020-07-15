using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
             for (int num_1 = 0; num_1 < 10; num_1++)
            {
                for (int num_2 = num_1 + 1 ; num_2 < 10; num_2++)
                    if (num_1 != num_2)
                    {
                        Console.Write("{0:d}", num_1);
                        if (num_1 == 8)
                            Console.WriteLine("{0}", num_2);
                        else
                            Console.Write("{0:d}, ", num_2);
                    }
            }
        }
    }
}
