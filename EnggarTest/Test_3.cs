using System;

public class Test_3
{
    public static string HighestPalindrome(string s, int k)
    {
        if (s.Length <= 1)
        {
            return k > 0 ? "9" : s;
        }

        char first = s[0];
        char last = s[s.Length - 1];
        if (first == last)
        {
            if (k > 1 && first != '9')
            {
                return "9" + HighestPalindrome(s.Substring(1, s.Length - 2), k - 2) + "9";
            }
            return first + HighestPalindrome(s.Substring(1, s.Length - 2), k) + last;
        }
        else if (k > 0)
        {
            if (first != '9' && last != '9')
            {
                k -= 2;
            }
            else if (first != '9' || last != '9')
            {
                k -= 1;
            }
            return "9" + HighestPalindrome(s.Substring(1, s.Length - 2), k) + "9";
        }
        else
        {
            return "-1";
        }
    }


}
