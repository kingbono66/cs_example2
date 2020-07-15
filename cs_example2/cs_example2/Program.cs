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
            int[] source = {1,2,3,4,5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source,target);
            foreach(int e in target)
            {
                Write($"{e} ");
            }

            string[] source1 = { "하나", "둘", "셋", "넷", "다섯" };
            string[] target1 = new string[source1.Length];

            CopyArray<string>(source1, target1);
            foreach (string e in target1)
            {
                Write($"{e} ");
            }
            WriteLine();

            bool[] source2 = { true, false, false, true, false};
            bool[] target2 = new bool[source2.Length];
            CopyArray<bool>(source2, target2);
            foreach (bool e in target2)
            {
                Write($"{e} ");
            }
            WriteLine();
        }

        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

    }

}
