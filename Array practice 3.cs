using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Array_practice_3
    {
        public static int[] CreateRandomArray()
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] Array = new int[size];
            Random randomArrayNumbers = new Random();
            for (int y = 0; y < Array.Length; y++)
            {
                Array[y] = randomArrayNumbers.Next(0, 100);
            }
            return Array;
        }
        public static int[] InsertIntoArray(int[] array, int position, int number)
        {
            int[] newArray = new int[array.Length + 1];
            for (int z = 0; z < position - 1; z++)
            {
                newArray[z] = array[z];
            }
            for (int z = position - 1; z < array.Length; z++)
            {
                newArray[z + 1] = array[z];
            }
            newArray[position - 1] = number;
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
            Console.WriteLine("Enter number to input it into array");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position into array");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Your array now looks like:");
            int[] newNums = InsertIntoArray(nums, position, number);
            for (int x = 0; x < newNums.Length; x++)
            {
                Console.WriteLine(newNums[x]);
            }
            Console.ReadLine();
        }
    }
}
