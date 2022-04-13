using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikasiNonThread_1295
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread tid = new MyThread();
            tid.Thread1();
            tid.Thread2();
            Console.ReadLine();
        }
    }
}
