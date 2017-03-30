using System;

namespace Exercises
{
    class Fibonachi
    {
       public static void Run()
        {
            int pervoe = 1;

            int vtoroe = 1;

            int predel;

           Console.WriteLine("Введите количество чисел фибоначи");

            predel = int.Parse(Console.ReadLine());

            for (int x = 0; x > predel; x++)
            {
               int ffibonachi = pervoe + vtoroe;

                pervoe = vtoroe;

                vtoroe = ffibonachi;
             
            }
              
            Console.WriteLine("Fibonachi  = " + ffibonachi);


            Console.ReadLine();
        }
    }
}
