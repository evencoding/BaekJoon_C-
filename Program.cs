﻿using System;

namespace BaekJoon_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            string numB = Console.ReadLine();

            // Char 형식에 int.Parse를 적용할 수 없기 때문에 .ToString()으로 string형식으로 바꿔줘야 함
            Console.WriteLine(numA * int.Parse(numB[2].ToString()));
            Console.WriteLine(numA * int.Parse(numB[1].ToString()));
            Console.WriteLine(numA * int.Parse(numB[0].ToString()));
            Console.WriteLine(numA * int.Parse(numB));
        }
    }
}
