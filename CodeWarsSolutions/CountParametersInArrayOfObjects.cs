using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//args_count(1, 2, 3)-> 3
//args_count(1, 2, 3, 10)-> 4

namespace CodeWarsSolutions
{
    internal class CountParametersInArrayOfObjects
    {
    }

    public static int CountArgs(params dynamic[] args) => args.Length;

    public static int CountArgs(params object[] o) => o.Length;


}
