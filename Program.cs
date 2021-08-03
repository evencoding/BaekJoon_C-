﻿using System;

namespace BaekJoon_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            string[] str = Console.ReadLine().Split();

            int max = -1000001;
            int min = 1000001;

            for (int i = 0; i < str.Length; i++){
                if(int.Parse(str[i]) > max){
                    max = int.Parse(str[i]);
                }
                if(int.Parse(str[i]) < min){
                    min = int.Parse(str[i]);
                }
            }
            Console.WriteLine($"{min} {max}");
        }
    }
}