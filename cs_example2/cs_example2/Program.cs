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
            ThereIsAFire call119 = new ThereIsAFire(
                delegate (string location)
                {
                    WriteLine($"소방서죠? {location}에 불이 났어요.");
                });
            call119 += new ThereIsAFire(ShotOut);
            call119 += new ThereIsAFire(Escape);


            call119("우리집");


            /*
            ThereIsAFire shotOut = new ThereIsAFire(ShotOut);
            shotOut("우리집");
            ThereIsAFire escape = new ThereIsAFire(Escape);
            escape("우리집");
            */

        }

        //static void Call119(string location)
        //{
        //    WriteLine($"소방서죠? {location}에 불이 났어요.");
        //}
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
