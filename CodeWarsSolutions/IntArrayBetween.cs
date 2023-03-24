//a = 1
//b = 4
//-- > [1, 2, 3, 4]

namespace CodeWarsSolutions
{
    internal class IntArrayBetween
    {
    public static int[] Between1(int a, int b)
    {
        return Enumerable.Range(a, b - a + 1).ToArray();
    }
    public static int[] Between2(int a, int b)
    {
        var result = new List<int>();
        for (var i = a; i <= b; i++)
        {
            result.Add(i);
        }
        return result.ToArray();
    }
   
}

}