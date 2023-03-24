using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//[TestFixture]
//public class SolutionTest
//{
//    private readonly object monitor = new object();
//    [Test]
//    public void SampleTests()
//    {
//        Worker w = new Worker();
//        Random rand = new Random();
//        int counter = 20;
//        int executionCounter = 0;
//        Action a = () => {
//            Console.Write('.');
//            Thread.Sleep(1000);
//            lock (monitor) { executionCounter++; }
//        };
//        w.Execute(a, 20);
//        if (counter != executionCounter)
//            Console.WriteLine($"Aciton was executed {executionCounter} times instead of {counter} times");
//        Assert.IsTrue(counter == executionCounter);
//    }
//}
//You're given a procedure / method that executes a passed action n times, but it does so in a purely 
//    sequential manner. If you inspect the sample tests, you'll find that the action takes about 1 second
//    to complete, and this action is repeated 20 times which results in a timeout.

//Find a way to execute the action n times in parallel, such that the sample tests complete under
//the 12 second time limit imposed by Codewars. The submission tests will also test for similar scenarios.

//Hint: If you're not sure where to start, read up on threads.


namespace CodeWarsSolutions
{
    internal class MultyThreadingParalellInvoke
    {

    public void Execute1(Action a, int nTimes)
    {
        Parallel.For(0, nTimes, x => a());
    }

    public void Execute2(Action a, int nTimes) => Parallel.ForEach(Enumerable.Range(1, nTimes), (i) => a());

    public void Execute3(Action a, int nTimes)
    {
        Task.WaitAll(Enumerable.Repeat(1, nTimes).Select(i => Task.Factory.StartNew(a)).ToArray());
    }

    public void Execute4(Action a, int nTimes)
    {
        List<Thread> threads = new List<Thread>();

        for (int i = 0; i < nTimes; i++)
        {
            threads.Add(new Thread(new ThreadStart(a)));
            threads[i].Start();
        }
        for (int i = 0; i < nTimes; i++)
        {
            threads[i].Join();
        }
    }

    public void Execute5(Action a, int nTimes)
    {
        var arr = new Action[nTimes];
        for (var i = 0; i < nTimes; i++)
            arr[i] = a;
        Parallel.Invoke(arr);
    }

    public void Execute6(Action a, int nTimes)
    {
        Action[] actions = new Action[nTimes];
        for (int i = 0; i < nTimes; i++)
        {
            actions[i] = a;
        }
        Parallel.Invoke(actions);
    }

    public void Execute7(Action a, int nTimes)
    {
        System.Threading.Tasks.Parallel.For(0, nTimes, _ => a());
    }

    public void Execute8(Action a, int nTimes)
    {
        var list = new List<Action>();
        for (int i = 0; i < nTimes; i++)
        {
            list.Add(a);
        }

        Parallel.Invoke(list.ToArray());
    }

    public void Execute9(Action a, int nTimes)
    {
        for (int i = 0; i < nTimes; i++)
        {
            Thread t = new Thread(new ThreadStart(a));
            t.Start();
            if (i >= nTimes * 0.9) t.Join();
        }
    }


}

}