using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[ [ 1, 2, 3, 4, 5 ]        #  minimum value of row is 1
//, [ 5, 6, 7, 8, 9 ]        #  minimum value of row is 5
//, [ 20, 21, 34, 56, 100 ]  #  minimum value of row is 20
//]

namespace CodeWarsSolutions
{
    internal class ThreeDimensinIntArrayFirstValueCount
    {

    public static int SumOfMinimums1(int[,] numbers)
    {
        var sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            var min = numbers[i, 0];
            for (int j = 1; j < numbers.GetLength(1); j++)
            {
                if (numbers[i, j] < min)
                    min = numbers[i, j];
            }
            sum += min;
        }
        return sum;
    }

    public static int SumOfMinimums2(int[,] numbers)
    {
        return Enumerable.Range(0, numbers.GetLength(0))
                    .Select(i => Enumerable.Range(0, numbers.GetLength(1)).Select(j => numbers[i, j]))
                    .Sum(row => row.Min());
    }

    public static int SumOfMinimums3(int[,] numbers)
    {
        int result = 0;
        List<int> list = new List<int>();
        foreach (int i in numbers)
        {
            list.Add(i);
            if (list.Count == numbers.GetLength(1))
            {
                result += list.Min();
                list.Clear();
            }
        }
        return result;
    }

    public static int SumOfMinimums4(int[,] numbers)
    {
        return Enumerable.Range(0, numbers.GetLength(0))
                     .Select(x => Enumerable.Range(0, numbers.GetLength(1)).Select(y => numbers[x, y]))
                     .Sum(x => x.Min());
    }

    public static int SumOfMinimums5(int[,] numbers)
    {
        return numbers.Cast<int>().Chunk(numbers.GetLength(1)).Sum(x => x.Min());
    }
}

}