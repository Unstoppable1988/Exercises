using System;

namespace Exercises
{
    class Factorial
    {
       public static void Run()
        {
            int chislo;

            int factorial = 1;

            Console.WriteLine("Введите число");

            chislo = int.Parse(Console.ReadLine());

            for (int x = chislo; x > 1; x--)

                factorial = factorial * x;

            Console.WriteLine("Факториал  = " + factorial);


            Console.ReadLine();
        }
    }
}
