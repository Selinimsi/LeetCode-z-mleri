using System;

class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        int[] result = new int[digits.Length + 1];
        result[0] = 1;

        return result;
    }
}

class Program
{
    static void Main()
    {
        Solution sol = new Solution();

        int[] test1 = { 1, 2, 3 };
        int[] test2 = { 4, 3, 2, 1 };
        int[] test3 = { 9, 9, 9 };

        PrintArray(sol.PlusOne(test1)); // 1 2 4
        PrintArray(sol.PlusOne(test2)); // 4 3 2 2
        PrintArray(sol.PlusOne(test3)); // 1 0 0 0
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
