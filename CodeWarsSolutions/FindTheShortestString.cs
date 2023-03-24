using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Simple, given a string of words, return the length of the shortest word(s).

//String will never be empty and you do not need to account for different data types.

namespace CodeWarsSolutions
{
    internal class FindTheShortestString
    {
    public static int FindShort1(string s)
    {
        string[] strArr = s.Split(' ');
        int maxx = int.MaxValue;

        foreach (string item in strArr)
        {
            if (item.Length < maxx)
            {
                maxx = item.Length;
            }
        }
        return maxx;
    }
    public static int FindShort2(string s)
    {
        return s.Split(' ').Min(x => x.Length);
    }
    public static int FindShort3(string str)
    {
        return str.Split(' ').Select(elem => elem.Length).Min();
    }
    public static int FindShort4(string s)
    {
        return s.Split(' ').OrderBy(str => str.Length).First().Length;
    }
}

}