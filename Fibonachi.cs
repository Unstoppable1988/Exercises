using System;

namespace Exercises
{
    class Fibonachi
    {
       public static void Run()
        {
            int pervoe = 0;

            int vtoroe = 1;

            int sum = 0;

            for (int x = 0; x < 4000000; x = pervoe + vtoroe)
            {
                pervoe = vtoroe;

                vtoroe = x;

                if (x % 2 == 0)
                {
                    sum = sum + x;
                }
                                
            }

            Console.WriteLine("Sum of the even-valued terms is  " + sum);

            Console.ReadLine();
        }
    }
}
