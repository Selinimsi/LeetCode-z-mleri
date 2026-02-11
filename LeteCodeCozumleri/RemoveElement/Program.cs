using System;

class Program
{
    static void Main()
    {
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;

        int newLength = RemoveElement(nums, val);

        Console.WriteLine("Yeni uzunluk: " + newLength);
        Console.Write("Yeni dizi: ");

        for (int i = 0; i < newLength; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }

    public static int RemoveElement(int[] nums, int val)
    {
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[index] = nums[i];
                index++;
            }
        }

        return index;
    }
}
