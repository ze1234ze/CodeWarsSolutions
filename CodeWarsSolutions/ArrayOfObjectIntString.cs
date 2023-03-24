using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public void SampleTest()
//{
//    Assert.AreEqual(2, Kata.DivCon(new object[] { 9, 3, "7", "3" }));
//    Assert.AreEqual(14, Kata.DivCon(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
//    Assert.AreEqual(13, Kata.DivCon(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
//    Assert.AreEqual(11, Kata.DivCon(new object[] { "1", "5", "8", 8, 9, 9, 2, "3" }));
//    Assert.AreEqual(61, Kata.DivCon(new object[] { 8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7 }));
//    Assert.AreEqual(-6, Kata.DivCon(new object[] { "0", "1", "2", "3" }));
//    Assert.AreEqual(6, Kata.DivCon(new object[] { 0, 1, 2, 3 }));
//    Assert.AreEqual(0, Kata.DivCon(new object[] { 1, "1" }));
//    Assert.AreEqual(-2, Kata.DivCon(new object[] { -1, "1" }));
//    Assert.AreEqual(2, Kata.DivCon(new object[] { 1, "-1" }));
//    Assert.AreEqual(1, Kata.DivCon(new object[] { 1 }));
//    Assert.AreEqual(-1, Kata.DivCon(new object[] { "1" }));
//    Assert.AreEqual(0, Kata.DivCon(new object[] { }));
//}

namespace CodeWarsSolutions
{
    internal class ArrayOfObjectIntString
    {
    public static int DivCon1(object[] arr)
    {
        int strings = 0, ints = 0;

        foreach (object el in arr)
        {
            if (el is string)
            {
                strings += int.Parse(el.ToString());
            }
            else if (el is int)
            {
                ints += (int)el;
            }
        }

        return ints - strings;
    }
    public static int DivCon2(Object[] objArray)
    {
        return objArray.Where(o => o.GetType() == typeof(int)).Sum(x => (int)x) -
               objArray.Where(o => o.GetType() == typeof(string)).Sum(x => int.Parse(x.ToString()));

    }
    public static int DivCon3(Object[] objArray)
    {
        int res = 0;
        foreach (object o in objArray)
        {
            res += typeof(string) == o.GetType() ? -Convert.ToInt32(o) : (int)o;
        }
        return res;
    }
    public static int DivCon4(Object[] objArray)
    {
        var stringTotal = 0;
        var intTotal = 0;

        foreach (var obj in objArray)
        {
            switch (obj)
            {
                case string value:
                    stringTotal += int.Parse(value);
                    break;

                case int value:
                    intTotal += value;
                    break;
            }
        }
        return intTotal - stringTotal;
    }
    public static object DivCon5(Object[] objArray)
    {
        int g = 0, a = 0, b = 0, c = 0, d = 0;

        for (int i = 0; i < objArray.Length; i++)
        {
            if (objArray[i] is string)
            {
                a = Convert.ToInt32(objArray[i]);
                b = b + a;
            }
            else if (objArray[i] is int)
            {
                c = Convert.ToInt32(objArray[i]);
                d = d + c;
            }
        }
        g = d - b;
        return g;
    }
    public static int DivCon6(object[] objArray)
    {
        return objArray.Sum(o => (o is int ? 1 : -1) * int.Parse(o.ToString()));
    }
    public static int DivCon7(Object[] objArray) => objArray.Sum(t => (t is int) ? (int)t : -int.Parse((string)t));
}

}