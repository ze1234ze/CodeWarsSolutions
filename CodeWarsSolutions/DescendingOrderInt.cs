using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Examples:

//Input: 42145 Output: 54421

//Input: 145263 Output: 654321

//Input: 123456789 Output: 987654321

namespace CodeWarsSolutions
{
    internal class DescendingOrderInt
    {
    }
    public static int DescendingOrder(int num)
    {
        char[] arr = num.ToString().ToCharArray();
        Array.Sort(arr);
        Array.Reverse(arr);
        return Convert.ToInt32(new string(arr));
    }
    public static int DescendingOrder(int num)
    {
        var chars = num.ToString().ToCharArray();
        Array.Sort(chars);
        Array.Reverse(chars);
        var s = new string(chars);
        return Int32.Parse(s);
    }
    public static int DescendingOrder(int num)
    {
        return int.Parse(string.Concat($"{num}".OrderByDescending(c => c)));
    }
    public static int DescendingOrder(int num)
    {
        var orderedList = num.ToString().OrderByDescending(n => n);
        return int.Parse(String.Concat(orderedList));
    }
    public static int DescendingOrder(int num)
    {
        return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
    }
}
