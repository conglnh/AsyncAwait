using System;
using System.Threading;

namespace AsyncAwaitBeginner
{
    class Program
    {
        static readonly object _object = new object();
        static void TestLock()
        {
            lock (_object)
            {

                Thread.Sleep(100);
                Console.WriteLine(Environment.TickCount);
            }
        }

        static void Main(string[] args)
        {
            //Thread noParam = new Thread(ThreadClass.ThreadWithoutParameter);
            //Thread withParam = new Thread(ThreadClass.ThreadWithParamater);
            //noParam.Start();  
            //withParam.Start();
            //Test thread.
            ThreadClass.ThreadWithoutParameter();

            //Thread with parameter
            ThreadClass.ThreadWithParamater();

            //Test Delegate.
            //DelegateClass.TestDelegate();

            Console.ReadKey();
            
        }
    }
}
