using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2,2,2-- > 2
//2,6,2-- > 12(2 + 4 + 6)
//1,5,1-- > 15(1 + 2 + 3 + 4 + 5)
//1,5,3-- > 5(1 + 4)

namespace CodeWarsSolutions
{
    internal class IterationIntArray
    {
    public static int SequenceSum1(int start, int end, int step)
    {
        int sum = 0;

        for (int i = start; i <= end; i += step)
        {
            sum += i;
        }

        return sum;
    }
    public static int SequenceSum2(int start, int end, int step)
    {
        int sum = 0;
        while (start <= end)
        {
            sum += start;
            start += step;
        }
        return sum;
    }
    public static int SequenceSum3(int start, int end, int step)
    {
        return start == end ? end : start > end ? 0 : SequenceSum4(start + step, end, step) + start;
    }
    public static int SequenceSum5(int start, int end, int step)
    {
        if (start > end)
        {
            return 0;
        }

        var n = (end - start) / step;

        return start * (n + 1) + step * n * (n + 1) / 2;
    }
    public static int SequenceSum6(int start, int end, int step)
    {
        int sum = 0;

        if (end >= end)
        {
            for (int i = start; i <= end; i += step)
            {
                sum += i;
            }
        }

        return sum;
    }
    public static int SequenceSum7(int start, int end, int step)
    {
        if (start > end) return 0;
        int sum = 0;
        for (int i = start; i <= end; i += step)
            sum += i;
        return sum;
    }
}

}