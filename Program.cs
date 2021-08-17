﻿// 2021-08-17

using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoon_C_
{
    class Program
    {
        static StringBuilder sb;
        static bool[] isCheaked;
        static int[] result;
        static string[] input_num;

        static void Main(string[] args)
        {
            sb = new StringBuilder();
            input_num = Console.ReadLine().Split();
            result = new int[int.Parse(input_num[0])];
            isCheaked = new bool[int.Parse(input_num[1])+1];

            permutation(0);
        }
        static void permutation(int num){
            if(num == int.Parse(input_num[1]))
            {
                for (int i = 0; i < num; i++){
                    sb.Append(result[i] + " ");
                }
                Console.WriteLine(sb);
                sb.Clear();
                return;
            }
            for (int i = 1; i <= int.Parse(input_num[0]); i++)
            {
                if(!isCheaked[i])
                {
                    isCheaked[i] = true;
                    result[num] = i;
                    permutation(num+1);
                    isCheaked[i] = false;
                }
            }
        }
    }
}