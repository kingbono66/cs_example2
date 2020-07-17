using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cs_example2
{
    delegate void ThereIsAFire(string location);
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Call119(string location)
        {
            WriteLine($"소방서죠? {location}에 불이 났어요.");
        }
        static void ShotOut(string location)
        {
            WriteLine($"피하세요 {location}에 불이 났어요.");
        }
        static void Escape(string location)
        {
            WriteLine($"{location}에서 도망갑시다!");
        }
    }

    
}
