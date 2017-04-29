using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Array_practice_2
    {
        public static int[] Array()
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("You check " + size + " size of array");
            int[] list = new int[size];
            Random randomArrayNumbers = new Random();
            for (int z = 0; z < list.Length; z++)
            {
                list[z] = randomArrayNumbers.Next(0, 100);
            }
            return list;
        }
        public static void Run()
        {
            int[] nums = Array();
            Console.WriteLine("Your generated array is:");
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine(nums[x]);
            }
            Console.WriteLine("Enter the number for check");
            int number = int.Parse(Console.ReadLine());
            for (int x = 0; x < nums.Length; x++)
            {
                if (number == nums[x])
                {
                    Console.WriteLine("Id of the number in array =" + x);
                    Console.ReadLine();
                }
            }
            Console.WriteLine("No number in the array");
            Console.ReadLine();
        }
    }
}
