using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingleInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mutex = null;
            const string mutexName = "RUNMEONLYONCE";

            while (true)
            {
                try
                {
                    mutex = Mutex.OpenExisting(mutexName);
                    mutex.Close();
                    Console.WriteLine("Closed existing Mutex");
                }
                catch (WaitHandleCannotBeOpenedException e)
                {
                    mutex = new Mutex(true, mutexName);
                    Console.WriteLine("Created new Mutex");
                }
            }
        }
    }
}
