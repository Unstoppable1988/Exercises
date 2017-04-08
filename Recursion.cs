using System;

namespace Exercises
{
    class Recursion
    {
        static int recursion(int x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            else
            {
                return recursion(x - 1) + recursion(x - 2);
            }
        }
        public static void Run()
        {
            int text = recursion(6);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
