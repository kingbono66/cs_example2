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
            Cat kitty = new Cat();
            kitty.name = "키티";
            kitty.color = "분홍색";
            kitty.Meow();

            Cat cat = new Cat();
            cat.name = "네로";
            cat.color = "검은색";
            cat.Meow();

            Cat unknown = new Cat();
            unknown.Meow();

        }
    }

    class Cat
    {
        public string name;
        public string color;

        public Cat()
        {
            name = "나비";
            color = "몰라";
        }

        public void Meow()
        {
            WriteLine($"{name}({color}) : 야옹");
        }

        ~Cat()
        {
            WriteLine($"{name} : bye");
        }

    }
}
