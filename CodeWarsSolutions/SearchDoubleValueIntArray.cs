using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example:

//For input: [3, 4, 4, 3, 6, 3]

//remove the 3 at index 0
//    remove the 4 at index 1
//    remove the 3 at index 3

//Expected output: [4, 6, 3]

namespace CodeWarsSolutions
{
    internal class SearchDoubleValueIntArray
    {

    public static int[] Solve1(int[] arr)
    {
        List<int> output = new List<int>();

        for (var i = arr.Length - 1; i >= 0; i--)
        {
            //add new elements to output list, each time checking if it hasnt been added yet
            if (!output.Contains(arr[i]))
            {
                output.Add(arr[i]);
            }
        }
        //reverse array to make it allign with what it wants in the tests
        output.Reverse();
        return output.ToArray();
    }

    public static int[] Solve2(int[] arr)
    {
        return arr.Reverse().Union(arr).Reverse().ToArray();
    }

    public static int[] Solve3(int[] arr)
    {
        return new HashSet<int>(arr.Reverse()).Reverse().ToArray();
    }

    public static int[] Solve4(int[] arr)
    {
        var stack = new Stack<int>();
        foreach (int x in arr.Reverse())
        {
            if (!stack.Contains(x))
            {
                stack.Push(x);
            }
        }
        return stack.ToArray();
    }

    public static int[] solve5(int[] arr)
    {

        return arr.Where((x, i) => !arr.Skip(i + 1).Contains(x)).ToArray();
    }

    public static int[] Solve6(int[] arr)
    {
        var list = new List<int>();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (!list.Contains(arr[i]))
            {
                list.Add(arr[i]);
            }
        }
        list.Reverse();
        return list.ToArray();
    }
}

}