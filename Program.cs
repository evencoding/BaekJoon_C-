﻿// 2021-08-04

using System;
using System.Text;

namespace BaekJoon_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= N; i++){
                sb.Append(i + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}