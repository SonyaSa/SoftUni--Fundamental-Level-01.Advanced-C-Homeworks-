using System;
using System.Linq;

namespace _SortArrayOfNumbersUsingSelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int [] nums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int tempLeft = 0;
            int tempRight = 0;

            for (int numLeft = 0; numLeft < nums.Length; numLeft++)
            {
                for (int numRight = 0; numRight < nums.Length; numRight++)
                {
                    if (nums [numLeft] < nums [numRight])
                    {
                        tempLeft = nums[numLeft];
                        tempRight = nums[numRight];

                        nums[numLeft] = tempRight;
                        nums[numRight] = tempLeft;
                    }
                }
            }

            foreach (var number in nums)
            {
                Console.Write(number + " ");
            }
        }
    }
}
