using System;

namespace Exercises
{
    class Factorial
    {
       public static void Run()
        {
            decimal chislo;

            decimal factorial = 1;

            Console.WriteLine("Введите число");

            chislo = int.Parse(Console.ReadLine());

            for (decimal x = chislo; x > 1; x--)

                factorial = factorial * x;

            Console.WriteLine("Факториал  = " + factorial);


            Console.ReadLine();
        }
    }
}
