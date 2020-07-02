using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Runtime.CompilerServices;

namespace cs_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }

    }

    class Base
    {
        protected string name;
        public Base(string name)
        {
            this.name = name;
            WriteLine($"{this.name}.Base()");
        }
        ~Base()
        {
            WriteLine($"{name}.~Base()");
        }
        public void BaseMethod()
        {
            WriteLine($"{name}.BaseMethod()");
        }

    }
    class Derived : Base
    {
        public Derived(string name) : base(name)
        {
            this.name = name;
            WriteLine($"{this.name}.Derived()");
        }
        ~Derived()
        {
            WriteLine($"{name}.~Derived()");
        }
        public void DerivedMethod()
        {
            WriteLine($"{name}.DerivedMethod()");
        }

    }
}
