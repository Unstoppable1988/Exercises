using System;

namespace Exercises
{
    class Squares_2_of_3
    {
        public static void Run()
        {
            int a;

            int b;

            int c;

            int square;

            Console.WriteLine("Введите первое число");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");

            c = int.Parse(Console.ReadLine());

            if ((a >= b) && (b >= c))
            {
                square = a * a + b * b;
            }
            else if ((b >= c) && (c >= a))
            {
                square = b * b + c * c;
            }
            else if ((c >= a) && (a >= b))
            {
                square = c * c + a * a;
            }
            else if ((a <= b) && (b <= c))
            {
                square = b * b + c * c;
            }
            else

                square = 0;
                Console.WriteLine("Squares sum  = " + square);


            Console.ReadLine();
        }
    }
}
