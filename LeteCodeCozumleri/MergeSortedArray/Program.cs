using System;

class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
    }
}

class Program
{
    static void Main()
    {
        Solution sol = new Solution();

        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };

        sol.Merge(nums1, 3, nums2, 3);

        foreach (var num in nums1)
        {
            Console.Write(num + " ");
        }
        // Output: 1 2 2 3 5 6
    }
}