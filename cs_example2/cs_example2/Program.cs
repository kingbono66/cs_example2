using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cs_example2
{
    delegate int Compare(int a, int b);
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
                BubbleSort(array, new Compare(AscendCompare));

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
                BubbleSort(array, new Compare(DescendCompare));

                foreach (int i in array)
                {
                    Write($"{i} ");
                }
                WriteLine();
            }
        }

        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        static void BubbleSort(int[] dataSet, Compare Comparer)
        {
            int temp = 0;

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
