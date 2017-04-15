using System;

namespace Exercises
{
    class Prime_10001
    {
        static int IsPrime()
        {
            int a = 10001;
            int x = 2;
            int z = 0;

            for (; ; x++)
            {
                bool isPrime = true;
                for (int y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    z = z + 1;
                }
                if (z == a)
                {
                    return x;
                }
            }
            return 0;
        }

        public static void Run()
        {
            Console.WriteLine(IsPrime());
            Console.ReadLine();
        }
    }
}
