using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 5;

        Solution solution = new Solution();
        int result = solution.SearchInsert(nums, target);

        Console.WriteLine("Sonuç: " + result);
    }
}

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return left;
    }
}
