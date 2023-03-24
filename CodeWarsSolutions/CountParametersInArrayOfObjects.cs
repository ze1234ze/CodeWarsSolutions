using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//args_count(1, 2, 3)-> 3
//args_count(1, 2, 3, 10)-> 4

//public void SampleTest()
//{
//    Assert.AreEqual(3, Kata.CountArgs(1, 2, 3));
//    Assert.AreEqual(3, Kata.CountArgs(1, 2, "uhsaf uas"));
//    Assert.AreEqual(1, Kata.CountArgs(1));
//    Assert.AreEqual(4, Kata.CountArgs('a', 865, "asfhgajsf", new object[] { "dawdjio", null, new List<object>() }));
//    Assert.AreEqual(0, Kata.CountArgs());
//}

namespace CodeWarsSolutions
{
    internal class CountParametersInArrayOfObjects
    {
    }

    public static int CountArgs(params dynamic[] args) => args.Length;

    public static int CountArgs(params object[] o) => o.Length;


}
