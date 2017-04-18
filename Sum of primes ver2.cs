using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Exercises
{
    class Sum_of_primes_2
    {
        public static decimal Sum_Prime()
        {
            int n = 2000000;
            int[] tab = new int[2000001];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 0;
            }

            decimal sum = 0;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (tab[i] == 0)
                {
                    for (int j = 2; j < n; j++)
                    {
                        if (j % i == 0 && i != j)
                        {
                            tab[j] = 1;
                        }
                    }
                }
            }
            for (int i = 2; i <= 2000000; i++)
            {
                if (tab[i] == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }


        public static void Run()
        {
            Console.WriteLine(Sum_Prime());
            Console.ReadLine();
        }
    }
}