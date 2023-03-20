using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//solution('abc', 'bc') // returns true
//solution('abc', 'd') // returns false

namespace CodeWarsSolutions
{
    internal class StringEndsWith
    {
    }
    public static bool Solution(string str, string ending)
    {
        return str.EndsWith(ending);
    }
    public static bool Solution(string str, string ending) => str.EndsWith(ending);
    public static bool Solution_HandWritten(string str, string ending)
    {
        if (str == null || ending == null || ending.Length > str.Length)
            return false;
        if (ending.Length == 0 || ReferenceEquals(str, ending))
            return true;

        int endingIndex = ending.Length - 1;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (endingIndex < 0)
                return true;

            if (str[i] != ending[endingIndex])
                return false;

            endingIndex--;
        }

        return endingIndex < 0;
    }
}
