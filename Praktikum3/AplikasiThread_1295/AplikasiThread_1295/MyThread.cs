using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AplikasiThread_1295
{
    class MyThread
    {
        public static void Thread1()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("cuci baju ke {0}", i);
                Thread.Sleep(3000);
            }
        }
        public static void Thread2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Setrika baju ke {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}
