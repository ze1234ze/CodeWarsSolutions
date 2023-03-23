using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//My friend wants a new band name for her band. She like bands that use the formula: "The" + a noun with the first letter capitalized, for example:

//"dolphin"-> "The Dolphin"

//However, when a noun STARTS and ENDS with the same letter, she likes to repeat the noun twice and connect them together with the first and last letter, combined into one word(WITHOUT "The" in front), like this:

//"alaska"-> "Alaskalaska"

//Complete the function that takes a noun as a string, and returns her preferred band name written as a string.


namespace CodeWarsSolutions
{
    internal class StringCharRepeatTestAndChange
    {
    }

    public static string BandNameGenerator(string str)
    {
        var name = char.ToUpper(str[0]) + str.Substring(1);
        return str.First() != str.Last() ? $"The {name}" : name + str.Substring(1);
    }

    public static string BandNameGenerator(string str)
    {
        if (str[0] == str[str.Length - 1])
        {
            // If the first and last letters are the same, concatenate the string with the first letter capitalized twice
            return str[0].ToString().ToUpper() + str.Substring(1) + str.Substring(1);
        }
        else
        {
            // Otherwise, prepend "The" to the capitalized string
            return "The " + str[0].ToString().ToUpper() + str.Substring(1);
        }
    }

    public static string BandNameGenerator(string str)
    {
        if (str[0] != str[str.Length - 1])
        {
            str = str.First().ToString().ToUpper() + str.Substring(1);
            str = "The " + str;
        }

        if (str[0] == str[str.Length - 1])
        {
            str = str + str.Substring(1);
            str = str.First().ToString().ToUpper() + str.Substring(1);

        }
        return str;
    }

}
