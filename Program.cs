using System;
using System.Collections.Generic;

namespace SWVL
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<int> data = new List<int> { 1, 2, 3 };
            Console.WriteLine("Combination : ");
            GetCombination(data);
            Console.WriteLine("Permutation : ");
            Permute(data.ToArray(),0,3);

        }
        static void GetCombination(List<int> list)
        {
            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        Console.Write(list[j]);
                    }
                }
                Console.WriteLine();
            }

        }


        static void Permute(int[] data, int i, int n)
        {
            int j;
            if (i == n)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write(data[k] + " ");
                }
                Console.WriteLine();
            }

            else
            {
                for (j = i; j < n; j++)
                {
                    Swap(ref data[i], ref data[j]);
                    Permute(data, i + 1, n);
                    Swap(ref data[i], ref data[j]); //backtrack
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

    }
}
