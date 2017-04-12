using System;

namespace Exercises
{
    class Smalest_multiplie
    {
        public static bool IsDividible(int z)
        {
            for (int a = 1; a < 21; a++)
            {
                if (z % a != 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Run()
        {
            public static bool Compilation()
            {
                for (int x = 1; ; x++)
                {
                    if (IsDividible(x) == false)
                    {
                        return true;
                    }
                }
                return false;
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}




