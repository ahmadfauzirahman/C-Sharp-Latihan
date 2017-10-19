using System;
using System.Collections.Generic;

namespace OutTest
{
    internal class Program
    {
        public static int Output (out int a)
        {
            a = 25;
            return 0;
        }
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine(Output(out a));
            Console.WriteLine(a);
        }
    }
}