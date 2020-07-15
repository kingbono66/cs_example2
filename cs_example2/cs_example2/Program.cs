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
            //Class c = new Class();
            //c.A = 3;
            //WriteLine(c.A);

            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "서현",
                Birthday = new DateTime(1991,6,28)
            };
            //WriteLine($"Name : {birth.Name}");
            //WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            //WriteLine($"Age : {birth.Age}");

            //birth.Name = "서현";
            //birth.Birthday = new DateTime(1991,6,28);

            WriteLine($"Name : {birth.Name}");
            WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            WriteLine($"Age : {birth.Age}");

        }


    }

    class Class
    {
        //private int a;
        
        /*
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        */
        public int A { get; set; }
    }

    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";

        public DateTime Birthday { get; set; } = new DateTime(1,1,1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

}
