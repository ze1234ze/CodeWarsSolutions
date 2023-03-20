using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Input->Output
//"8 j 8   mBliB8g  imjB8B8  jl  B"-> "8j8mBliB8gimjB8B8jlB"
//"8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"-> "88Bifk8hB8BB8BBBB888chl8BhBfd"
//"8aaaaa dddd r     "-> "8aaaaaddddr"

namespace CodeWarsSolutions
{
    internal class StringLeehrAustauschen
    {

    }
    namespace Solution
    {
        public static class SpacesRemover
        {
            public static string NoSpace(string input)
            {
                return input.Replace(" ", "");
            }
        }
    }
    namespace Solution
    {
        public static class SpacesRemover
        {
            public static string NoSpace(string input)
            {
                return input.Replace(" ", string.Empty);
            }
        }
    }
    namespace Solution
    {
        public static class SpacesRemover
        {
            public static string NoSpace(string input)
            {
                return input != null ? input.Replace(" ", "") : null;
            }
        }
    }
}
