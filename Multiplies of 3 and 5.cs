using System;

namespace Exercises
{
    class Multiplies_of_3_and_5
    {
        public static void Run()
        {
            int x = 0;

            for (int z = 0; z < 1000; z++)
            {
                if (z%3 == 0 || z % 5 == 0)
                {
                    x = x + z;
                } 
            }

            Console.WriteLine("Multipies sum  = " + x);


            Console.ReadLine();
        }
    }
}
