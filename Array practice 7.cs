using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Array_practice_7
    {
        public static int[] CreateRandomArray()
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random randomArrayNumbers = new Random();
            for (int y = 0; y < array.Length; y++)
            {
                array[y] = randomArrayNumbers.Next(0, 10);
            }
            return array;
        }
        public static int[] FindNumberIntoArray(int[] array, int number)
        {
            int[] result = new int[0];
            for (int z = 0; z < array.Length; z++)
            {
                if (array[z] == number)
                {
                    result = InsertIntoArray(result, z);
                }
            }
            return result;
        }
        public static int[] InsertIntoArray(int[] oldArray, int positionNumber)
        {
            int[] newArray = new int[oldArray.Length + 1];
            for (int z = 0; z < newArray.Length - 1; z++)
            {
                newArray[z] = oldArray[z];
            }
            newArray[oldArray.Length] = positionNumber + 1;
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
            Console.WriteLine("Enter number to find it index into array");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Position of the number into array is:");
            int[] newNums = FindNumberIntoArray(nums, number);
            for (int x = 0; x < newNums.Length; x++)
            {
                Console.WriteLine(newNums[x]);
            }
            Console.ReadLine();
        }
    }
}
