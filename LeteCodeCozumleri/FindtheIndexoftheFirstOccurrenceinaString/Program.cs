using System;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Console.Write("Haystack giriniz: ");
        string haystack = Console.ReadLine();

        Console.Write("Needle giriniz: ");
        string needle = Console.ReadLine();

        int result = solution.StrStr(haystack, needle);

        Console.WriteLine("Sonuç: " + result);
    }
}

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle == "") return 0;

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack.Substring(i, needle.Length) == needle)
            {
                return i;
            }
        }

        return -1;
    }
}
