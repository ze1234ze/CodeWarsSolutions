using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[true,  true,  true,  false,
//  true,  true,  true,  true ,
//  true,  false, true,  false,
//  true,  false, false, true ,
//  true,  true,  true,  true ,
//  false, false, true,  true]

namespace CodeWarsSolutions
{
    internal class BoolsInArrayCount
    {
    }

    public static int CountSheeps(bool[] sheeps)
    {
        return sheeps.Count(s => s);
    }
    public static int CountSheeps(bool[] sheeps)
    {
        int count = 0;
        foreach (bool sheep in sheeps)
        {
            if (sheep) count++;
        }
        return count;
    }
    public static int CountSheeps(bool[] sheeps)
    {
        int numTrue = 0;
        //TODO
        foreach (bool isTrue in sheeps)
        {
            if (isTrue == true)
            {
                numTrue++;
            }
        }
        return numTrue;
    }
    public static int CountSheeps(bool[] sheeps)
    {
        int sheepsCount = 0;

        if (sheeps.Length == 0)
            return 0;

        for (int i = 0; i < sheeps.Length; i++)
        {
            if (sheeps[i])
                sheepsCount++;
        }
        return sheepsCount;
    }
    //Ungefähre meine Lösung
    public static int CountSheeps(bool[] sheeps)
    {
        int answer = 0;
        for (int i = 0; i < sheeps.Length; i++)
        {
            if (sheeps[i] == true) { answer++; }
        }
        return answer;
    }
}
