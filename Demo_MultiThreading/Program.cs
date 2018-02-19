using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
// this is just a test Just Checking
namespace Demo_MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart th1 = new ThreadStart(f1);
            ThreadStart th2 = new ThreadStart(f2);

            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);

            t1.Start();     // Initializing Threads into ThreadPool
            t2.Start();

        }

        static void f1()
        {
            for(int i=1;i<=20;i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside F1 ......." + i);
            }
        }

        static void f2()
        {
            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside F2 ......." + i);
            }
        }
    }
}
