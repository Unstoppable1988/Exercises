using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Triangle_Number
    {
        public static decimal TriangleNubmers(int amount)
        {
            decimal sum = 0;
            for (decimal x = 1; ; x++)
            {
                sum = sum + x;
                int countNumbers = 0;
                for (decimal y = 1; y <= sum; y++)
                {
                    if (sum % y == 0)
                    {
                        countNumbers = countNumbers + 1;
                        if (countNumbers == amount)
                        {
                            return sum;
                        }
                    }
                }
            }
        }
        public static void Run()
        {
            Console.WriteLine(TriangleNubmers(500));
            Console.ReadLine();
        }
    }
}
