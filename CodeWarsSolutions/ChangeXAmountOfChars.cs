using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//"4556364607935616"-- > "############5616"
//     "64607935616"-- > "#######5616"
//               "1"-- > "1"
//                ""-- > ""

//// "What was the name of your first pet?"

//"Skippy"-- > "##ippy"

//"Nananananananananananananananana Batman!"
//-- >
//"####################################man!"
namespace CodeWarsSolutions
{
    internal class ChangeXAmountOfChars
    {
    public static string Maskify1(string cc)
    {
        int len = cc.Length;
        if (len <= 4)
            return cc;

        return cc.Substring(len - 4).PadLeft(len, '#');
    }
    public static string Maskify2(string cc)
    {
        var cs = cc.ToCharArray();

        for (int i = 0; i < cc.Length - 4; i++)
        {
            cs[i] = '#';
        }

        return string.Concat(cs);
    }
    public static string Maskify3(string cc)
    {
        return Regex.Replace(cc, ".(?=.{4})", "#");
    }
    public static string Maskify4(string cc)
    {
        if (cc.Length < 5)
            return cc;

        return new String('#', cc.Length - 4) + cc.Substring(cc.Length - 4);
    }
    public static string Maskify5(string cc)
    {
        return string.Concat(cc.TakeLast(4)).PadLeft(cc.Length, '#');
    }
    public static string Maskify6(string cc)
    {
        if (cc.Length < 5) return cc;

        string s = new string('#', cc.Length - 4);

        return s + cc.Substring(cc.Length - 4);
    }
    public static string Maskify7(string cc)
    {
        int j = cc.Length;

        if (j < 5) return cc;

        int i = j - 4;
        string s = new string('#', i);

        return s + cc.Substring(i);
    }
}

}