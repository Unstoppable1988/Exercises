using System;

namespace Exercises
{
    class Palindrome
    {
        public static int Chislo()
        {
            int a;
            int b = 0;

            for (int x = 335; x < 1000; x++)
            {
                for (int y = 335; y < 1000; y++)
                {
                    a = x * y;
                    string s = a.ToString();
                    if (s[0] == s[5] && s[1] == s[4] && s[3] == s[2] && a > b)
                    {
                        b = a;
                    }
                }
            }
            return b;
        }
        public static void Run()
        {
            Console.WriteLine(Chislo());
            Console.ReadLine();
        }
    }
}




