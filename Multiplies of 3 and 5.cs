using System;

namespace Exercises
{
    class Multiplies_of_3_and_5
    {
       public static void Run()
        {
            int x = 0;

            int a = 0;

            int i;

            for (int y = x; y < 1000; y=y+3)
                
                x = x + y;

            for (int b = a; b < 1000; b = b + 5)

                a = a + b;

            i = a + x;  


                Console.WriteLine("Multipies sum  = " + i);


            Console.ReadLine();
        }
    }
}
