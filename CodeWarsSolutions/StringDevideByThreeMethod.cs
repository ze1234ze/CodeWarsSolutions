using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//A trick I learned in elementary school to determine whether or not a number was divisible
//    by three is to add all of the integers in the number together and to divide the resulting 
//    sum by three. If there is no remainder from dividing the sum by three, then the original
//    number is divisible by three as well.

//Given a series of digits as a string, determine if the number represented by the string is divisible by three.

//Example:
//"123"-> true
//"8409"-> true
//"100853"-> false
//"33333333"-> true
//"7"-> false

namespace CodeWarsSolutions
{
    internal class StringDevideByThreeMethod
    {
    }

    public static bool DivisibleByThree(string n)
    {
        return BigInteger.Parse(n) % 3 == 0;
    }

    public static bool DivisibleByThree(string n)
    {
        return n.Sum(x => x) % 3 == 0;
    }

    public static bool DivisibleByThree(string n)
    {
        var numSequence = n.ToCharArray();
        var res = 0;

        foreach (var e in numSequence)
            res += e;

        if (res % 3 == 0)
            return true;
        else
            return false;
    }

    public static bool DivisibleByThree(string n)
    {
        return n.Select(x => int.Parse(x.ToString())).Sum() % 3 == 0;
    }

    public static bool DivisibleByThree(string n)
    {
        int a = 0;
        foreach (char s in n)
        {
            a += Int32.Parse(s.ToString());
        }
        return a % 3 == 0;
    }

    public static bool DivisibleByThree(string n)
    {
        return n.Sum(n => char.GetNumericValue(n)) % 3 == 0;
    }

    public static bool DivisibleByThree(string n)
    {
        int sum = 0;
        char[] array = n.ToCharArray();

        foreach (char c in array)
        {
            sum += int.Parse(c.ToString());
        }

        return sum % 3 == 0 ? true : false;
    }


}
