using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Digital Cypher assigns to each letter of the alphabet unique number. For example:

// a b  c  d  e  f  g  h  i  j  k  l  m
// 1  2  3  4  5  6  7  8  9 10 11 12 13
// n  o  p  q  r  s  t  u  v  w  x  y  z
//14 15 16 17 18 19 20 21 22 23 24 25 26

//Instead of letters in encrypted word we write the corresponding number, eg. The word scout:

// s c  o  u  t
//19  3 15 21 20

//Then we add to each obtained digit consecutive digits from the key. For example. In case of key equal to 1939 :

//   s c  o  u  t
//  19  3 15 21 20
// + 1  9  3  9  1
// ---------------
//  20 12 18 30 21
  
//   m  a  s  t  e  r  p  i  e  c  e
//  13  1 19 20  5 18 16  9  5  3  5
//+  1  9  3  9  1  9  3  9  1  9  3
//  --------------------------------
//  14 10 22 29  6 27 19 18  6  12 8

namespace CodeWarsSolutions
{
    internal class DigitalCypherIntChar
    {
    }
    public static int[] Encode(string str, int n)
    {
        string sN = n.ToString();              // 1939 => "1939"
        char[] chN = sN.ToCharArray();         // {'1', '9', '3', '9'}
        int[] nArrN = new int[chN.Length];     //
        for (int i = 0; i < nArrN.Length; i++) // 
        {
            nArrN[i] = chN[i] - 48;               // {1, 9, 3, 9}
        }

        char[] chArr = str.ToCharArray();      //  {'s', 'c', 'o', 'u', 't'}
        int[] nRet = new int[chArr.Length];    // 
        for (int i = 0; i < chArr.Length; i++)
        {
            nRet[i] = chArr[i] - 96 + nArrN[i % nArrN.Length];// {}
        }
        return nRet;
    }

    public static int[] Encode(string str, int n)
    {
        var coded = new int[str.Length];
        var map = n.ToString();

        for (int index = 0; index < str.Length; index++)
        {
            coded[index] = (int)str[index] - 96 + map[index % map.Length] - 48;
        }
        return coded;
    }

    public static int[] Encode(string str, int n)
    {
        int[] result = new int[str.Length];
        string nStr = n.ToString();

        while (nStr.Length <= str.Length)
        {
            nStr += nStr;
        }

        for (int i = 0; i < str.Length; i++)
        {
            int charSum = 0;

            charSum += (str[i] - 'a') + 1;
            charSum += nStr[i] - '0';

            result[i] = charSum;
        }

        return result;
    }

    public static int[] Encode(string str, int n)
    {
        string s = n.ToString();
        return str.Select((x, i) => x - 96 + (s[i % s.Length] - '0')).ToArray();
    }

    public static int[] Encode(string str, int n) => str.Select((c, i) => c + n.ToString()[i % n.ToString().Length] - 144).ToArray();




}
