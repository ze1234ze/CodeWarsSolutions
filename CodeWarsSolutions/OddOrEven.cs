using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

namespace CodeWarsSolutions
{
    internal class OddOrEven
    {
    public static string EvenOrOdd1(int number)
    {
        if (number % 2 == 0)
        {
            return "Even";

        }
        else return "Odd";
    }
    public static string EvenOrOdd2(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
    public static string EvenOrOdd3(int number)
 => number % 2 == 0 ? "Even" : "Odd";
    public static string EvenOrOdd4(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }

}

}