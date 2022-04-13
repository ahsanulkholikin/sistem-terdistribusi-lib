using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikasiNonThread_1295
{
    class MyThread
    {
        public void Thread1()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("cuci baju ke {0}", i);
            }
        }
        public void Thread2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Setrika baju ke {0}", i);
            }
        }
    }
}
