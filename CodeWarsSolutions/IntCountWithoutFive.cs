using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1,9-> 1,2,3,4,6,7,8,9->Result 8
//4,17-> 4,6,7,8,9,10,11,12,13,14,16,17->Result 12

namespace CodeWarsSolutions
{
    internal class IntCountWithoutFive
    {
    }

    public static int DontGiveMeFive(int start, int end)
    {
        int count = 0;
        for (int i = end; i >= start; i--)
            if (!(i.ToString().Contains("5")))
                count++;
        return count;
    }

    public static int DontGiveMeFive(int start, int end)
    {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            string temp = i.ToString();
            if (!temp.Contains("5")) count++;
        }

        return count;
    }

    public static int DontGiveMeFive(int start, int end)
    {
        return Enumerable.Range(start, end - start + 1).Count(x => !x.ToString().Contains("5"));
    }

    public static int DontGiveMeFive(int start, int end)
    {
        return Enumerable.Range(start, end - start + 1).Count(i => i.ToString().IndexOf('5') == -1);
    }

    public static int DontGiveMeFive(int start, int end)
    {
        int count = 0;

        for (int i = start; i <= end; ++i)
            if (!i.ToString().Contains("5"))
                count++;

        return count;
    }

    public static int DontGiveMeFive(int start, int end)
    {
        List<int> numberCollection = new List<int>();
        // Get all numbers within the range
        // Store numbers in a list
        for (int i = start; i <= end; i++)
        {
            numberCollection.Add(i);
        }

        // Remove all numbers that contain 5 from the array
        int count = 0;
        foreach (int number in numberCollection)
        {
            if (!number.ToString().Contains("5"))
            {
                //numberCollection.Remove(number);
                count = count + 1;
            }
        }

        return count;
    }

    public static int DontGiveMeFive(int start, int end)
    {
        return Enumerable.Range(start, end - start + 1).Count(x => !x.ToString().Contains("5"));
    }

}
