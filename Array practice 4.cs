using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Array_practice_4
    {
        public static int[] CreateRandomArray()
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random randomArrayNumbers = new Random();
            for (int y = 0; y < array.Length; y++)
            {
                array[y] = randomArrayNumbers.Next(0, 100);
            }
            return array;
        }
        public static int[] DeleteFromArray(int[] array, int position)
        {
            int[] newArray = new int[array.Length - 1];
            for (int z = 0; z < position - 1; z++)
            {
                newArray[z] = array[z];
            }
            for (int z = position - 1; z < newArray.Length; z++)
            {
                newArray[z] = array[z + 1];
            }
            return newArray;
        }
        public static void Run()
        {
            int[] nums = CreateRandomArray();
            Console.WriteLine("Your random created array is:");
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine(nums[x]);
            }
            Console.WriteLine("Enter position to delete it from array");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Your array now looks like:");
            int[] newNums = DeleteFromArray(nums, position);
            for (int x = 0; x < newNums.Length; x++)
            {
                Console.WriteLine(newNums[x]);
            }
            Console.ReadLine();
        }
    }
}
