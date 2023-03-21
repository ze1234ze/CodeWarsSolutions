using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//    It's pretty straightforward. Your goal is to create a function that removes the first and last characters
//    of a string. You're given one parameter, the original string. 
//    You don't have to worry with strings with less than two characters.
namespace CodeWarsSolutions
{
    internal class RemoveFirstAndLastLetter
    {
    }
    public static string Remove_char(string s)
    {
        return Regex.Replace(s, "^.|.$", "");
    }
    public static string Remove_char(string s)
    {
        char[] letras = new char[s.Length - 2];
        for (int i = 1; i < s.Length - 1; i++)
        {
            letras[i - 1] = s[i];
        }
        return new string(letras);
    }
    public static string Remove_char(string s)
    {
        return s[1..^1];
    }
    public static string Remove_char(string s) => s.Remove(s.Length - 1).Remove(0, 1);
}
