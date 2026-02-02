using System;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        string[] strs1 = { "flower", "flow", "flight" };
        Console.WriteLine(solution.LongestCommonPrefix(strs1));
        // Çıktı: fl

        string[] strs2 = { "dog", "racecar", "car" };
        Console.WriteLine(solution.LongestCommonPrefix(strs2));
        // Çıktı: (boş string)

        Console.ReadLine();
    }
}

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        // En kısa string'i bul
        string shortest = strs[0];
        foreach (string s in strs)
        {
            if (s.Length < shortest.Length)
                shortest = s;
        }

        // Prefix kontrolü
        for (int i = 0; i < shortest.Length; i++)
        {
            char c = shortest[i];
            foreach (string s in strs)
            {
                if (s[i] != c)
                    return shortest.Substring(0, i);
            }
        }

        return shortest;
    }
}
