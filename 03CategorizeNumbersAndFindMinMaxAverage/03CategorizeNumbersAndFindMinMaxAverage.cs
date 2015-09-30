using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbersAndFindMinMaxAverage
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        double[] nums = new double[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = double.Parse(input[i]);
        }

        List<double> intNums = new List<double>();
        List<double> doubleNums = new List<double>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0 || nums[i] % 2 == 1)
            {
                intNums.Add(nums[i]);
            }
            else
            {
                doubleNums.Add(nums[i]);
            }
        }

        Console.Write("[");

        foreach (var number in intNums)
        {

            Console.Write("{0}, ", number);
        }

        Console.Write("] -> ");
        Console.Write("min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
        intNums.Min(), intNums.Max(), intNums.Sum(), intNums.Average());

        Console.WriteLine();

        Console.Write("[");

        foreach (var number in doubleNums)
        {

            Console.Write("{0}, ", number);
        }

        Console.Write("] -> ");
        Console.Write("min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
        doubleNums.Min(), doubleNums.Max(), doubleNums.Sum(), doubleNums.Average());
    }
}
