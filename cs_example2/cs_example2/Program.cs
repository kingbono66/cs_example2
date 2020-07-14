using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace cs_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            WriteLine("쓰레드 시작...");
            t1.Start();

            for( int i = 0; i < 5; i++)
            {
                WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }
            WriteLine("쓰레드 끝날 때까지 대기");
            t1.Join();
            WriteLine("끝");
        }

        static void DoSomething()
        {
            for( int i = 0; i < 10; i++)
            {
                WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }
    }
}
