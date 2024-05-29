using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    
    public static class Test_2
    {
        public static string IsBalanced(string s)
        {
        var list = new List<char>();

        foreach (var ch in s)
        {
            switch (ch)
            {
                case '{':
                case '[':
                case '(':
                    list.Add(ch);
                    break;
                case '}':
                    if (list.Count == 0 || list[list.Count - 1] != '{')
                    {
                        return "NO";
                    }
                    list.RemoveAt(list.Count - 1);
                    break;
                case ']':
                    if (list.Count == 0 || list[list.Count - 1] != '[')
                    {
                        return "NO";
                    }
                    list.RemoveAt(list.Count - 1);
                    break;
                case ')':
                    if (list.Count == 0 || list[list.Count - 1] != '(')
                    {
                        return "NO";
                    }
                    list.RemoveAt(list.Count - 1);
                    break;
            }
        }

        return list.Count == 0 ? "YES" : "NO";
        }

    }


