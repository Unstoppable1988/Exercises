using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Sum_of_primes_1
    {
        public static decimal isPrime(decimal c)
        {
            decimal a = 2;

            for (decimal x = 3; x < c; x++)
            {
                bool isPrime = true;
                for (decimal y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    a = a + x;
                }
            }
            return a;
        }
        public static void Run()
        {
            Console.WriteLine(isPrime(20000));
            Console.ReadLine();
        }
    }
}
