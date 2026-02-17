public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int length = 0;
        int i = s.Length - 1;

        // sondaki boşlukları geç
        while (i >= 0 && s[i] == ' ')
            i--;

        // son kelimenin uzunluğunu say
        while (i >= 0 && s[i] != ' ')
        {
            length++;
            i--;
        }

        return length;
    }
}
