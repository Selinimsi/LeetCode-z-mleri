using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        // Stack kullanarak açılan parantezleri takip edeceğiz
        Stack<char> stack = new Stack<char>();

        // Parantez eşleşmelerini bir dictionary'de tutalım
        Dictionary<char, char> parenthesesMap = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        // String'in her karakterini kontrol et
        foreach (char c in s)
        {
            // Eğer karakter açılan bir parantez ise stack'e ekle
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            // Eğer karakter kapalı bir parantez ise
            else if (c == ')' || c == ']' || c == '}')
            {
                // Stack boşsa veya en üstteki parantez eşleşmiyorsa false dön
                if (stack.Count == 0 || stack.Peek() != parenthesesMap[c])
                {
                    return false;
                }
                // Eşleşiyorsa stack'ten çıkar
                stack.Pop();
            }
        }

        // Tüm karakterler kontrol edildikten sonra stack boş olmalı
        return stack.Count == 0;
    }
}

// Test için örnek kullanım
class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.IsValid("()"));      // true
        Console.WriteLine(solution.IsValid("()[]{}"));  // true
        Console.WriteLine(solution.IsValid("(]"));      // false
        Console.WriteLine(solution.IsValid("([)]"));    // false
        Console.WriteLine(solution.IsValid("{[]}"));    // true
        Console.WriteLine(solution.IsValid(""));        // true (boş string geçerlidir)
    }
}