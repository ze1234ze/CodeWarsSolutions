using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given an array of integers your solution should find the smallest integer.

//For example:

//    Given[34, 15, 88, 2] your solution will return 2
//    Given [34, -345, -1, 100] your solution will return -345

//You can assume, for the purpose of this kata, that the supplied array will not be empty.

namespace CodeWarsSolutions
{
    internal class TheSmallestIntInArray
    {
    public static int FindSmallestInt1(int[] args)
    {
        return args.Min();
    }
    public static int FindSmallestInt2(int[] args)
    {
        int small = args[0];
        foreach (int num in args)
        {
            if (small > num)
            {
                small = num;
            }
        }
        return small;
    }
    public static int FindSmallestInt3(int[] args)
    {
        Array.Sort(args);

        return args[0];
    }
    public static int FindSmallestInt4(int[] args)
    {
        return Enumerable.Min(args);
    }
    public static int FindSmallestInt5(int[] args)
    {
        int min = args[0];

        for (int i = 1; i < args.Length; i++)
        {
            if (args[i] <= args[i - 1]) min = args[i];
        }

        return min;
    }
}

}