using System;


namespace Exercises
{
    class Replace_word
    {
        public static int[] Replace(int[] number)
        {
            for (int a = 0; a < number.Length; a++)
            {
                if (number[a] == 1)
                {
                    number[a] = 2;
                }
            }
            return number;
        }
        public static void Run()
        {
            int[] nums = Replace(new int[] { 1, 2, 3, 1, 4, 5, 1 });
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine(nums[x]);
                
            }
            Console.ReadLine();
        }
    }
}
