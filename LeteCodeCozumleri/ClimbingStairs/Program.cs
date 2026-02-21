using System;

class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2)
            return n;

        int first = 1;
        int second = 2;

        for (int i = 3; i <= n; i++)
        {
            int third = first + second;
            first = second;
            second = third;
        }

        return second;
    }
}

class Program
{
    static void Main()
    {
        Solution sol = new Solution();

        Console.WriteLine(sol.ClimbStairs(2)); // 2
        Console.WriteLine(sol.ClimbStairs(3)); // 3
        Console.WriteLine(sol.ClimbStairs(5)); // 8
    }
}