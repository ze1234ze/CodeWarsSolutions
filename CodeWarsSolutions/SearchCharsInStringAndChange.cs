using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//uncensor("*h*s *s v*ry *tr*ng*", "Tiiesae") ➜ "This is very strange"

//uncensor("A**Z*N*", "MAIG") ➜ "AMAZING"

//uncensor("xyz", "") ➜ "xyz"

namespace CodeWarsSolutions
{
    internal class SearchCharsInStringAndChange
    {
    }

    public static string Uncensor(string infected, string discovered)
    {
        var result = string.Empty;
        var index = 0;
        for (int i = 0; i < infected.Length; i++)
        {

            if (infected[i] == '*')
            {
                result += discovered[index];
                index++;
            }
            else
            {
                result += infected[i];
            }
        }

        return result;
    }

    public static string Uncensor(string infected, string discovered)
    {
        char[] res = new char[infected.Length];
        int j = 0;

        for (int i = 0; i < infected.Length; i++)
        {
            if (infected[i] == '*')
            {
                res[i] = discovered[j];
                j++;
            }
            else
                res[i] = infected[i];
        }

        return new string(res);
    }

    public static string Uncensor(string infected, string discovered, int i = 0)
    {
        return string.Concat(infected.Select(x => x == '*' ? discovered[i++] : x));
    }
    public static string Uncensor(string infected, string discovered)
    {
        var result = new StringBuilder(infected);

        if (discovered.Length == 0)
            return result.ToString();

        int j = 0;

        for (int i = 0; i < result.Length; i++)
            if (result[i] == '*')
                result[i] = discovered[j++];

        return result.ToString();
    }

    public static string Uncensor(string infected, string discovered, int i = 0)
    {
        return Regex.Replace(infected, @"\*", (x) => discovered[i++].ToString());
    }

    public static string Uncensor(string infected, string discovered)
    {
        var indexes =
            infected.Select((n, i) => n == '*' ? i : -1)
            .Where(n => n != -1).ToArray();
        int replaceAt = 0;
        var updated = infected.Select((n, i) => n == '*' ? discovered[replaceAt++] : n);

        return string.Concat(updated);
    }
}
