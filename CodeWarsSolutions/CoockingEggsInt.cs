using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rules

//    you can put at most 8 eggs into the pot at once
//    it takes 5 minutes to boil an egg
//    we assume, that the water is boiling all the time (no time to heat up)
//    for simplicity we also don't consider the time it takes to put eggs into the pot or get them out of it

//Example(Input-- > Output)

//0-- > 0
//5-- > 5
//10-- > 10


namespace CodeWarsSolutions
{
    internal class CoockingEggsInt
    {
    public static int CookingTime1(int eggs)
    {
        return (eggs + 7) / 8 * 5;
    }

    public static int CookingTime2(int eggs)
    {
        return 5 * (int)Math.Ceiling(eggs / 8d);
    }

    public static int CookingTime3(int eggs)
    {
        // Keep track of how many minutes it took to cook the eggs
        int runTime = 0;

        // Early outs: if there are no eggs to cook, it takes 0 minutes
        // also, if there are less than or equal to 8 eggs to cook, it takes 5 minutes
        if (eggs == 0)
        {
            return 0;
        }
        else if (eggs <= 8)
        {
            return 5;
        }

        // Loop this code as many times as there are eggs (essentially, put the eggs
        // in the pot)
        for (int i = 0; i < eggs; i++)
        {
            // Every 8 eggs you put in, add 5 minutes to the run time (don't bother simulating
            // that extra time)
            if (i % 8 == 0)
            {
                runTime += 5;
            }
        }
        // Finally, return how long it took
        return runTime;
    }
    public static int CookingTime4(int eggs)
    {
        // TODO

        //eggs as input

        //if eggs less than or equal to 8 => 5 min
        //if eggs more than 8 && <= 16  it will take => 5 min + 5 min
        // following the same logic
        int time = 0;

        for (int i = 0; i < eggs; i += 8)
        {
            time = time + 5;
        }
        return time;



    }

    public static int CookingTime5(int eggs)
    {
        if (eggs == 0)
        {
            return 0;
        }

        if (eggs <= 8)
        {
            return 5;
        }
        else
        {
            int modulus = eggs % 8;
            if (modulus == 0)
            {
                int iter3 = eggs / 8;
                return iter3 * 5;
            }
            else
            {
                int iter2 = eggs / 8;
                iter2++;
                return iter2 * 5;
            }
        }
    }

    public static int CookingTime6(int eggs)
    {
        // TODO
        int number = eggs / 8;

        if (eggs % 8 > 0) number++;

        return number * 5;
    }
}

}