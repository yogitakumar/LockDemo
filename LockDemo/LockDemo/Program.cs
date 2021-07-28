using System;
using System.Threading;

namespace LockDemo
{
    internal class Program
    {
        private static readonly object _object = new object();

        private static void TestLock()
        {
            lock (_object)
            {
                Thread.Sleep(100);
                Console.WriteLine(Environment.TickCount);
            }
        }

        private static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                ThreadStart start = new ThreadStart(TestLock);
                new Thread(start).Start();
            }

            Console.ReadLine();
        }
    }
}