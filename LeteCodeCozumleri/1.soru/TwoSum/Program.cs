using System;
using System.Collections.Generic;

namespace LeetCodeTwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }

                // Aynı sayı birden fazla kez gelebilir
                if (!numDict.ContainsKey(nums[i]))
                {
                    numDict.Add(nums[i], i);
                }
            }

            return new int[0];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            // Test 1
            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] result1 = solution.TwoSum(nums1, target1);
            Console.WriteLine($"Test 1 - Input: [2, 7, 11, 15], Target: 9");
            Console.WriteLine($"Result: [{result1[0]}, {result1[1]}]"); // [0, 1]
            Console.WriteLine();

            // Test 2
            int[] nums2 = { 3, 2, 4 };
            int target2 = 6;
            int[] result2 = solution.TwoSum(nums2, target2);
            Console.WriteLine($"Test 2 - Input: [3, 2, 4], Target: 6");
            Console.WriteLine($"Result: [{result2[0]}, {result2[1]}]"); // [1, 2]
            Console.WriteLine();

            // Test 3
            int[] nums3 = { 3, 3 };
            int target3 = 6;
            int[] result3 = solution.TwoSum(nums3, target3);
            Console.WriteLine($"Test 3 - Input: [3, 3], Target: 6");
            Console.WriteLine($"Result: [{result3[0]}, {result3[1]}]"); // [0, 1]
            Console.WriteLine();

            // Test 4
            int[] nums4 = { 1, 5, 3, 7, 8 };
            int target4 = 10;
            int[] result4 = solution.TwoSum(nums4, target4);
            Console.WriteLine($"Test 4 - Input: [1, 5, 3, 7, 8], Target: 10");
            Console.WriteLine($"Result: [{result4[0]}, {result4[1]}]"); // [1, 3] (5 + 7 = 10)

            Console.ReadKey();
        }
    }
}