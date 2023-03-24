using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6, "I"-> "IIIIII"
//5, "Hello"-> "HelloHelloHelloHelloHello"

namespace CodeWarsSolutions
{
    internal class AddString
    {

        public static string repeatStr1(int n, string s)
        {
            return String.Concat(Enumerable.Repeat(s, n));
        }
        public static string repeatStr2(int n, string s)
        {
            var res = "";
            for (int i = 0; i < n; i++)
            {
                res += s;
            }
            return res;
        }
        public static string repeatStr3(int n, string s)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                builder.Append(s);
            }
            return builder.ToString();
        }

        public static string repeatStr4(int n, string s)
        {
            string a = s;
            while (--n > 0) a += s;
            return a;
        }
        public static string repeatStr5(int n, string s)
        {
            string t = "";

            for (int i = 0; i < n; i++)
            {
                t = s + t;
            }
            return t;
        }

    }
}
