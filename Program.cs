﻿using System;
using System.Collections.Generic;

namespace BaekJoon_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();
            for (int i = 0; i < N; i++){
                int inputNum = int.Parse(Console.ReadLine());
                nums.Add(inputNum);
            }
            for (int i = 0; i < N; i++){
                for (int j = N-1; j > i; j--)
                {
                    if (nums[j] < nums[j - 1]){
                        int temp = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = temp;
                    }
                }
            }
            for (int i = 0; i < nums.Count; i++){
                Console.WriteLine(nums[i]);
            }
        }
    }
}