// 2021-08-20

using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoon_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            count_num((a * b * c).ToString());
        }
        static void count_num(string result)
        {
            int[] count = new int[10];

            for (int i = 0; i < result.Length; i++)
            {
                int temp = int.Parse(result[i].ToString());
                count[temp]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);
            }
        }
    }
}