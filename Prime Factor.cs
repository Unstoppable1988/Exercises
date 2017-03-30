using System;

namespace Exercises
{
    class Prime_Factor
    {
        public static void Run()
        {
            Console.WriteLine("Введите число");

            decimal chislo;

            chislo = decimal.Parse(Console.ReadLine());

            for (decimal z = 2; z < chislo; z++)
            {
                if (chislo%z == 0)
                {
                    chislo = chislo / z;
                } 
            }
            Console.WriteLine(chislo);

            Console.ReadLine();
        }
    }
}
