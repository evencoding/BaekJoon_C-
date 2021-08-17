// 2021-08-17

using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoon_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string input = Console.ReadLine();
                if(input == null) break;
                string[] N = input.Split();
                int a = int.Parse(N[0]);
                int b = int.Parse(N[1]);
                Console.WriteLine(a + b);
            }
        }
    }
}