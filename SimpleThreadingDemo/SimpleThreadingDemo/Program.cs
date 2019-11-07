using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Counting);
            Thread thread = new Thread(threadStart);
            Thread thread1 = new Thread(threadStart);
            thread.Start();
            thread1.Start();
            thread.Join();
            thread1.Join();
            Console.ReadKey();
        }

        public static void Counting()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
