using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*'Hello world'   => true
//* ' Hello world'  => false
//* 'Hello world  ' => false
//* 'Hello  world'  => false
//* 'Hello'         => true

//Even though there are no spaces, it is still valid because none are needed:
//*'Helloworld'    => true
//* 'Helloworld '   => false
//* ' '             => false
//* ''              => true

namespace CodeWarsSolutions
{
    internal class StringSpacesCheck
    {
    }

    public static bool ValidSpacing(string s)
    {
        if (s.Length != s.Trim().Length)
        {
            return false;
        }

        if (s.Contains("  "))
        {
            return false;
        }

        return true;
    }

    public static bool ValidSpacing(string input)
    {
        if (input == "")
        {
            return true;
        }
        if (input[0] == ' ' || input[input.Length - 1] == ' ')
        {
            return false;
        }
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == ' ' && input[i - 1] == ' ')
            {
                return false;
            }
        }
        return true;
    }

    public static bool ValidSpacing(string s)
    {
        return s.Trim(' ') == s && !s.Contains("  ");
    }

    public static bool ValidSpacing(string s)
    {
        return s.Equals(string.Join(' ', s.Split(' ').Where(s => !string.IsNullOrEmpty(s))));
    }

    public static bool ValidSpacing(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (i == 0 && s[i] == ' ') return false;
            if (i == s.Length - 1 && s[i] == ' ') return false;
            if (i > 0 && s[i] == ' ' && s[i - 1] == ' ') return false;
        }

        return true;
    }


}
