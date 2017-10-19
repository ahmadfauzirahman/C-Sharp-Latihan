using System;
using System.Collections.Generic;

namespace ContohBreak
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("i=" + i);
                if (i==5) break;
            }
            Console.ReadLine();
        }
    }
}