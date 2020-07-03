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
            Mammal mammal = new Dog();
            Dog dog;

            if(mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();
            Cat cat = mammal2 as Cat;
            if (cat != null)
            {
                cat.Meow();
            }

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                WriteLine("cat2는 고양이가 아니야");

        }

        class Mammal
        {
            public void Nurse()
            {
                WriteLine("젖먹이");
            }
        }
        class Dog : Mammal
        {
            public void Bark()
            {
                WriteLine("멍!");
            }
        }
        class Cat : Mammal
        {
            public void Meow()
            {
                WriteLine("야옹~");
            }
        }
    }
}
