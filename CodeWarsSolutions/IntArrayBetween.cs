using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a = 1
//b = 4
//-- > [1, 2, 3, 4]

namespace CodeWarsSolutions
{
    internal class IntArrayBetween
    {
    }
    public static int[] Between(int a, int b)
    {
        return Enumerable.Range(a, b - a + 1).ToArray();
    }
    public static int[] Between(int a, int b)
    {
        var result = new List<int>();
        for (var i = a; i <= b; i++)
        {
            result.Add(i);
        }
        return result.ToArray();
    }
    public static int[] Between(int a, int b)
    {
        return Enumerable.Range(Min(a, b), Abs(a - b) + 1).ToArray();
    }
}
