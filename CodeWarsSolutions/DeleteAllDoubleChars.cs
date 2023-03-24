using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//accum("abcd")-> "A-Bb-Ccc-Dddd"
//accum("RqaEzty")-> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
//accum("cwAt")-> "C-Ww-Aaa-Tttt"

namespace CodeWarsSolutions
{
    internal class DeleteAllDoubleChars
    {

    public static String Accum1(string input)
    {
        var parts =
          // Take the string
          input
            // Turn each character to a repeated string based on it's index
            .Select((character, index) => new String(character, index + 1))
            // Then turn that string into a string where the first character is upper cased, and the rest is left alone
            .Select(subString => subString.Substring(0, 1).ToUpper() + subString.Substring(1).ToLower());

        // We will end up with everything joined by dashes     
        return String.Join("-", parts);
    }

    public static String Accum2(string s)
    {
        // your code
        string result = "";
        char[] stringArray;
        stringArray = s.ToCharArray();
        for (int i = 0; i < stringArray.Length; i++)
        {
            char.ToLower(stringArray[i]);
            for (int j = 0; j <= i; j++)
            {
                if (j == 0)
                {
                    result = result + char.ToUpper(stringArray[i]);
                }
                else
                {
                    result = result + char.ToLower(stringArray[i]);
                }
            }
            if (i != stringArray.Length - 1)
            {
                result = result + '-';
            }

        }
        return result;
    }

    public static string Accum3(string s)
    {
        if (s.Length < 1) return "";

        StringBuilder sb = new StringBuilder();
        int count = 1;
        foreach (char c in s.ToLower())
            sb.Append(Char.ToUpper(c), 1)
              .Append(c, count++ - 1)
              .Append('-');

        return sb.ToString().TrimEnd('-');
    }
    public static string Accum(string s)
    {
        return string.Join("-", s.ToLower().Select((c, i) => char.ToUpper(c) + new string(c, i)));
    }
    public static String Accum4(string s)
    {
        string result = "";
        int count = 0;
        foreach (char c in s.ToUpper())
        {
            Console.WriteLine(c);
            if (count != 0) result += "-";
            result += c + new String(char.ToLower(c), count);
            ++count;
        }
        return result;
    }

    public static String Accum5(string s)
    {
        int count = 0;
        string result = "";

        foreach (char c in s.ToUpper())
        {
            if (count != 0) result += "-";
            result += c;
            result += new String(char.ToLower(c), count);
            ++count;
        }
        return result;
    }
    public static string Accum6(string s) => string.Join("-", s.ToLower().Select((x, i) => char.ToUpper(x) + new string(x, i)));
}

}