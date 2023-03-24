using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

//Example: (Input-- > Output)

//"Dermatoglyphics"-- > true "aba"-- > false "moOse"-- > false(ignore letter case)

//isIsogram "Dermatoglyphics" = true
//isIsogram "moose" = false
//isIsogram "aba" = false


namespace CodeWarsSolutions
{
    internal class StringCharsRepeat
    {
    public static bool IsIsogram1(string str)
    {
        str = str.ToLower();
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < (str.Length); j++)
            {
                if (str[i] == str[j]) return false;
            }
        }
        return true;
    }
    public static bool IsIsogram2(string str)
    {
        return !Regex.IsMatch(str, @"([a-z]).*\1", RegexOptions.IgnoreCase);
    }
    public static bool IsIsogram(string str)
    {
        str = str.ToLower();
        char[] charArr = str.ToCharArray();

        Array.Sort(charArr);

        for (int i = 0; i < charArr.Length - 1; i++)
        {
            if (charArr[i] == charArr[i + 1])
                return false;
        }
        return true;
    }
    
          public static bool IsIsogram3(string str)
    {
        return new HashSet<char>(str.ToLower()).Count == str.Length;
    }
    public static bool IsIsogram4(string str)
    {
        return str.Length == new HashSet<char>(str.ToLower()).Count;
    }
}

}