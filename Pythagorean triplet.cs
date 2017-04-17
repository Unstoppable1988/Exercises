using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Pythagorean_triplet
    {
        public static int Triplet()
        {
            for (int x = 1; x < 998; x++)
            {
                for (int y = 2; y < 999; y++)
                {
                    for (int z = 3; z < 1000; z++)
                    {
                        if (x * x < y * y && y * y < z * z && (x * x) + (y * y) == z * z)
                        {
                            if (x + y + z == 1000)
                            {
                                return x * y * z;
                            }
                        }
                    }
                }
            }
            return 0;
        }
        public static void Run()
        {
            Console.WriteLine(Triplet());
            Console.ReadLine();
        }

    }
}
