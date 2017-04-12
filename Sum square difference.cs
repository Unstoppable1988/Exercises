using System;

namespace Exercises
{
    class Sum_square_difference
    {
        public static int SumSquare(int z)
        {
            int b = 0;

            for (int a = 1; a <= z; a++)
            {
                b = (a * a) + b;
            }
            return b;
        }
        public static int SquareSum(int y)
        {
            int b = 0;

            for (int a = 1; a <= y; a++)
            {
                b = a + b;
            }
            return b * b;
        }
        public static void Run()
        {
        Console.WriteLine(SquareSum(100)-SumSquare(100));
        Console.ReadLine();
        }
    }
}




