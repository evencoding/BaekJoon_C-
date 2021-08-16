// 2021-08-16

using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoon_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            string[] nums = Console.ReadLine().Split(' ');

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < int.Parse(str[0]); i++){
                if(int.Parse(nums[i]) < int.Parse(str[1])){
                    sb.Append(nums[i] + " ");
                }
            }
            Console.WriteLine(sb);
        }
    }
}