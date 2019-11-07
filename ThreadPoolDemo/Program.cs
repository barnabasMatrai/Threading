using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback waitCallback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(waitCallback, "hello");
            ThreadPool.QueueUserWorkItem(waitCallback, "hi");
            ThreadPool.QueueUserWorkItem(waitCallback, "Good day!");
            Console.ReadKey();
        }

        public static void ShowMyText(object state)
        {
            string str = (string)state;
            str += Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine(str);
        }
    }
}
