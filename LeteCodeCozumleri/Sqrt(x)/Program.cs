using System;

class Solution
{
    public int MySqrt(int x)
    {
        if (x < 2)
            return x;

        long left = 1;
        long right = x / 2;
        long result = 0;

        while (left <= right)
        {
            long mid = left + (right - left) / 2;
            long square = mid * mid;

            if (square == x)
                return (int)mid;

            if (square < x)
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return (int)result;
    }
}

class Program
{
    static void Main()
    {
        Solution sol = new Solution();

        Console.WriteLine(sol.MySqrt(4));   // 2
        Console.WriteLine(sol.MySqrt(8));   // 2
        Console.WriteLine(sol.MySqrt(16));  // 4
        Console.WriteLine(sol.MySqrt(27));  // 5
    }
}