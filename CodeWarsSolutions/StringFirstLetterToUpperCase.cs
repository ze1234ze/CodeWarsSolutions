using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//"riley"-- > "Hello Riley!"
//"JACK"-- > "Hello Jack!"

namespace CodeWarsSolutions

{
    internal class StringFirstLetterToUpperCase
    {
    }
    public static string Greet(string name)
    {
        return $"Hello {name.ToUpper()[0] + name[1..].ToLower()}!";
    }
    public static string Greet(string name) => $"Hello {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower())}!";
    public static string Greet(string name) => "Hello " + name.ElementAt(0).ToString().ToUpper() + name.Substring(1).ToLower() + "!";
    public static string Greet(string name)
    {
        string temp = name.ToLower();
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
        string result = myTI.ToTitleCase(temp);
        return "Hello " + result + "!";
    }
}
