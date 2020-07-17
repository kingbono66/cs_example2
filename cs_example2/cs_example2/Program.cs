using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cs_example2
{
    delegate int Compare<T>(T a, T b);
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array = { 3, 7, 4, 2, 10 };

                foreach (int i in array)
                {
                    Write($"{i} ");
                }
                WriteLine();

                WriteLine("오름차순 정렬");
                BubbleSort<int>(array, new Compare<int>(AscendCompare<int>));

                foreach (int i in array)
                {
                    Write($"{i} ");
                }
                WriteLine();
            }
            WriteLine();

            {
                int[] array = { 3, 7, 4, 2, 10 };

                foreach (int i in array)
                {
                    Write($"{i} ");
                }
                WriteLine();

                WriteLine("내림차순 정렬");
                BubbleSort<int>(array, new Compare<int>(DescendCompare<int>));

                foreach (int i in array)
                {
                    Write($"{i} ");
                }
                WriteLine();
            }

            {
                float[] array = { 3.2f, 7.4f, 4.5f, 2.1f, 10.4f };

                foreach (float i in array)
                {
                    Write($"{i} ");
                }
                WriteLine();

                WriteLine("내림차순 정렬");
                BubbleSort<float>(array, new Compare<float>(DescendCompare<float>));

                foreach (float i in array)
                {
                    Write($"{i} ");
                }
                WriteLine();
            }
        }

        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
            
        }
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return -a.CompareTo(b);

        }
        static void BubbleSort<T>(T[] dataSet, Compare<T> Comparer)
        {
            T temp;

            for( int i = 0; i < dataSet.Length - 1; i++)
            {
                for( int j = 0; j <dataSet.Length - (i+1); j++)
                {
                    if(Comparer(dataSet[j],dataSet[j+1]) > 0)
                    {
                        temp = dataSet[j + 1];
                        dataSet[j + 1] = dataSet[j];
                        dataSet[j] = temp;
                    }
                }
            }
        }
    }

}

/*
static void CopyArray<T>(T[] source, T[] target)
{
    for (int i = 0; i < source.Length; i++)
        target[i] = source[i];
}
*/