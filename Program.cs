// 2021-08-17

using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoon_C_
{
    class Program
    {
        static List<int> input_list;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            input_list = new List<int>();
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                int input_num = int.Parse(Console.ReadLine());
                if(input_num == 0)
                {
                    if(input_list.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        input_list.RemoveAt(input_list.Count - 1);
                    }
                }
                else
                {
                    input_list.Add(input_num);
                }
            }
            for (int i = 0; i < input_list.Count; i++)
            {
                sum += input_list[i];
            }
            Console.WriteLine(sum);
        }
    }
}