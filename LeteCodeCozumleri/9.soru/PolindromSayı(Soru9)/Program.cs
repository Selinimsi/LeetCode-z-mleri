using System;

namespace PalindromeNumberSolution
{
    public class Solution
    {
        /// <summary>
        /// Bir sayının palindrom olup olmadığını kontrol eder
        /// </summary>
        /// <param name="x">Kontrol edilecek sayı</param>
        /// <returns>Palindrom ise true, değilse false</returns>
        public bool IsPalindrome(int x)
        {
            // Negatif sayılar palindrom olamaz
            // Son rakamı 0 olan pozitif sayılar da palindrom olamaz (0 hariç)
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int reversed = 0;

            // Sayının yarısını ters çevir
            while (x > reversed)
            {
                int lastDigit = x % 10;          // Son rakamı al
                reversed = reversed * 10 + lastDigit; // Ters çevrilmiş sayıya ekle
                x /= 10;                         // Son rakamı çıkar
            }

            // Çift basamaklı: x == reversed
            // Tek basamaklı: x == reversed / 10 (ortadaki rakamı atla)
            return x == reversed || x == reversed / 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Palindrome Number Checker ===\n");

            Solution solution = new Solution();

            // Test edilecek sayılar
            int[] testNumbers = { 121, -121, 10, 0, 12321, 1221, 12345, 1001, -101, 123321 };

            Console.WriteLine("Sayı\t\tPalindrom?\tAçıklama");
            Console.WriteLine(new string('-', 50));

            foreach (int number in testNumbers)
            {
                bool result = solution.IsPalindrome(number);
                string explanation = GetExplanation(number, result);
                Console.WriteLine($"{number}\t\t{result}\t\t{explanation}");
            }

            // Kullanıcıdan sayı girişi al
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("Kendi sayınızı test edin (Çıkmak için 'q' girin):");

            while (true)
            {
                Console.Write("\nSayı girin: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;
                }

                if (int.TryParse(input, out int userNumber))
                {
                    bool userResult = solution.IsPalindrome(userNumber);
                    Console.WriteLine($"→ {userNumber} sayısı {(userResult ? "PALINDROM" : "PALINDROM DEĞİL")}");
                }
                else
                {
                    Console.WriteLine("Geçerli bir sayı girin!");
                }
            }
        }

        static string GetExplanation(int number, bool isPalindrome)
        {
            if (number < 0) return "Negatif sayılar palindrom olamaz";
            if (number == 0) return "0 her zaman palindromdur";
            if (number % 10 == 0) return "Son rakamı 0 olan pozitif sayılar palindrom olamaz";

            if (isPalindrome)
            {
                return $"Tersi kendisine eşit: {number} → {ReverseNumber(number)}";
            }
            else
            {
                return $"Tersi kendisine eşit değil: {number} → {ReverseNumber(number)}";
            }
        }

        static int ReverseNumber(int n)
        {
            int reversed = 0;
            int original = Math.Abs(n);

            while (original > 0)
            {
                reversed = reversed * 10 + original % 10;
                original /= 10;
            }

            return n < 0 ? -reversed : reversed;
        }
    }
}