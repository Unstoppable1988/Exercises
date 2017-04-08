using System;

namespace Exercises
{
    class Prime_Factor_ver2
    {
        static bool IsFactor(int z, decimal a)
        {
            return a % z == 0;
        }

        static bool IsPrime(int a)
        {
            for (int x = 2; x < a; x++)
            {
                bool check = IsFactor(x, a);

                if (check == true)
                {
                    return false;
                }
               
            }
            return true;
        }
        public static void Run()
        {
            bool text = IsPrime(6857);
            
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
