using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        int k = RemoveDuplicates(nums);

        Console.WriteLine("Yeni uzunluk: " + k);

        Console.Write("Benzersiz elemanlar: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }

    static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int k = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
