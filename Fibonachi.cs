using System;

namespace Exercises
{
    class Fibonachi
    {
       public static void Run()
        {
            int pervoe = 0;

            int vtoroe = 1;

            int predel;

           Console.WriteLine("Введите количество чисел фибоначи");

            predel = int.Parse(Console.ReadLine());

            for (int x = 0; x < predel; x++)
            {
               int chislo = pervoe + vtoroe;

                pervoe = vtoroe;

                vtoroe = chislo;

                if (chislo%2 == 0)
                {
                    Console.WriteLine(chislo);
                }

                
            }
              
            Console.ReadLine();
        }
    }
}
