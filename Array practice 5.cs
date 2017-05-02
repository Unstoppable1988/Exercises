using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Array_practice_5
    {
        public static int[] CreateFirstRandomArray()
        {
            Console.WriteLine("Enter the size of first array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random randomArrayNumbers = new Random();
            for (int y = 0; y < array.Length; y++)
            {
                array[y] = randomArrayNumbers.Next(0, 100);
            }
            return array;
        }
        public static int[] CreateSecondRandomArray()
        {
            Console.WriteLine("Enter the size of second array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random randomArrayNumbers = new Random();
            for (int y = 0; y < array.Length; y++)
            {
                array[y] = randomArrayNumbers.Next(0, 100);
            }
            return array;
        }
        public static int[] InsertIntoArray(int[] firstArray, int[] secondArray, int position)
        {
            int[] newArray = new int[firstArray.Length + secondArray.Length];
            for (int z = 0; z < position - 1; z++)
            {
                newArray[z] = firstArray[z];
            }
            for (int z = position - 1; z < position - 1 + secondArray.Length; z++)
            {
                newArray[z] = secondArray[z - (position - 1)];
            }
            for (int z = position - 1 + secondArray.Length; z < newArray.Length; z++)
            {
                newArray[z] = firstArray[z - secondArray.Length];
            }
            return newArray;
        }
        public static void Run()
        {
            int[] firstArray = CreateFirstRandomArray();
            Console.WriteLine("Your first random created array is:");
            for (int x = 0; x < firstArray.Length; x++)
            {
                Console.WriteLine(firstArray[x]);
            }
            int[] secondArray = CreateSecondRandomArray();
            Console.WriteLine("Your second random created array is:");
            for (int x = 0; x < secondArray.Length; x++)
            {
                Console.WriteLine(secondArray[x]);
            }
            Console.WriteLine("Enter position into first array to input there second array");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Your new united array now looks like:");
            int[] newArray = InsertIntoArray(firstArray, secondArray, position);
            for (int x = 0; x < newArray.Length; x++)
            {
                Console.WriteLine(newArray[x]);
            }
            Console.ReadLine();
        }
    }
}
