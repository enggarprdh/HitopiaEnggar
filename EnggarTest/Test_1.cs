using System;
using System.Collections.Generic;

public static class Test_1
{
    public static List<string> WeightedStrings(string s, int[] queries)
    {
        var weights = new HashSet<int>();
        var lastChar = '\0';
        var count = 0;

        foreach (var Char in s)
        {
            if (Char == lastChar)
            {
                count++;
            }
            else
            {
                count = 1;
                lastChar = Char;
            }
            weights.Add(count * (Char - 'a' + 1));
        }

        var result = new List<string>();
        foreach (var query in queries)
        {
            result.Add(weights.Contains(query) ? "Yes" : "No");
        }

        return result;
    }

}
