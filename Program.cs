// 2021-08-14

using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoon_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++){
                for (int j = 0; j <= i; j++){
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}