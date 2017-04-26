using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Sort_array
    {
        public static int[] Array(int[] numbers)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                for (int z = 0; z < numbers.Length - 1; z++)
                {
                    if (numbers[z] > numbers[z + 1])
                    {
                        int bubble = numbers[z];
                        numbers[z] = numbers[z + 1];
                        numbers[z + 1] = bubble;
                    }
                }
            }
            return numbers;
        }
        public static void Run()
        {
            int[] nums = Array(new int[] { 3, 5, 2, 6, 1 });
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine(nums[x]);

            }
            Console.ReadLine();
        }
    }
}