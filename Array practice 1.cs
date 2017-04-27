using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Array_practice_1
    {
        public static int[] Array()
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] list = new int[size];
            Random randomArrayNumbers = new Random();
            for (int z = 0; z < list.Length; z++)
            {
                list[z] = randomArrayNumbers.Next(0,1000);
            }
            return list;
        }
        public static void Run()
        {
            int[] nums = Array();
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine(nums[x]);
            }
            Console.ReadLine();
        }
    }
}
