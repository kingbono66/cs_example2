using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cs_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("아머슈트 생성");
            ArmorSuit armorSuit = new ArmorSuit();
            armorSuit.Initialize();

            WriteLine("\n아이언맨 생성");
            ArmorSuit ironman = new IronMan();
            ironman.Initialize();

            WriteLine("\n워머신 생성");
            ArmorSuit warMachine= new WarMachine();
            warMachine.Initialize();
        }
    }
    class ArmorSuit
    {
        public virtual void Initialize()
        {
            WriteLine("갑옷 장착");
        }
    }
    class IronMan : ArmorSuit
    {
        public new void Initialize()
        {
            base.Initialize();
            WriteLine("리펄서빔 장착");
        }
    }
    class WarMachine : ArmorSuit
    {
        public override void Initialize()
        {
            base.Initialize();
            WriteLine("더블배럴 캐논 장착");
            WriteLine("마이크로 로켓런처 장착");
        }

    }
}
