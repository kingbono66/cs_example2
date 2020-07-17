using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cs_example2
{
    delegate void DoSomething();
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Action<int> Do = (i) =>
            {
                WriteLine("aaa");
                WriteLine("bbb");
                WriteLine($"{i}");
            };
            Do(1);
            */

            Func<int> f = () => 10;
            WriteLine(f());
            Func<int, int, string> f1 = (a, b) =>  (a + b).ToString();
            WriteLine(f1(3,5));
        }
    }
}
