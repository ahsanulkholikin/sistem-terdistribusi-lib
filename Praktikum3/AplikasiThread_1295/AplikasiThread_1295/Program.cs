using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AplikasiThread_1295
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==");
            Console.WriteLine("Mulai melakukan pekerjaan");
            Console.WriteLine("==");

            Thread tid1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread tid2 = new Thread(new ThreadStart(MyThread.Thread2));

            tid1.Start();
            tid2.Start();

            Console.ReadLine();
        }
    }
}
