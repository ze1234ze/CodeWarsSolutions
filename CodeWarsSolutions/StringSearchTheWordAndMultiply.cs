using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//[Test]
//public void MyTest()
//{
//    Assert.AreEqual("is-is-is", Kata.ModifyMultiply("is very easy to resolve that kata", 0, 3), "should return 'is-is-is'");
//    Assert.AreEqual("cheap-cheap-cheap-cheap", Kata.ModifyMultiply("Talk is cheap Show me the code", 2, 4), "should return 'cheap-cheap-cheap'");
//    Assert.AreEqual("think-think-think-think-think-think", Kata.ModifyMultiply("Everyone in this country should learn how to program because it teaches you how to think", 15, 6), "should return is-is-is");
//    Assert.AreEqual("ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance", Kata.ModifyMultiply("Is sloppiness in code caused by ignorance or apathy? I don't know and I don't care.", 6, 8), "should return 'ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance'");
//    Assert.AreEqual("around-around-around-around-around", Kata.ModifyMultiply("Everything happening around me is very random. I am enjoying the phase, as the journey is far more enjoyable than the destination.", 2, 5), "should return'around-around-around-around-around'");
//}

namespace CodeWarsSolutions
{
    internal class StringSearchTheWordAndMultiply
    {
    }

    public static string ModifyMultiply(string str, int loc, int num)
    {
        List<string> result = new List<string>();
        string word = str.Split(' ')[loc];
        for (int i = 0; i < num; i++)
            result.Add(word);

        return System.String.Join("-", result);
    }

    public static string ModifyMultiply(string str, int loc, int num)
    {
        return string.Join('-', Enumerable.Repeat(str.Split(' ')[loc], num));
    }

    public static string ModifyMultiply(string str, int loc, int num)
    {
        var res = "";
        var words = str.Split(" ");
        for (int i = 0; i < num - 1; i++)
            res += words[loc] + "-";
        res += words[loc];
        return res;
    }

    public static string ModifyMultiply(string str, int loc, int num)
      => string.Join('-', Enumerable.Repeat(str.Split(' ')[loc], num));

    public static string ModifyMultiply(string str, int loc, int num)
    {
        try
        {
            string str1 = "";
            for (int i = 0; i < num; i++)
            {
                str1 = str1 + str.Split(" ")[loc].ToString();

                if (i != num - 1)
                {
                    str1 = str1 + "-";
                }
            }

            return str1.Trim('-');
        }
        catch (Exception ex)
        {
            Console.WriteLine("AAAAa = " + ex.Message.ToString());
            throw;
        }
    }

    public static string ModifyMultiply(string str, int loc, int num)
    {
        string[] words = str.Split(" ");
        string selected = words[loc];
        string result = selected;
        int i = 1;
        while (i < num)
        {
            result += "-" + selected;
            i++;
        }
        return result;
    }

}
