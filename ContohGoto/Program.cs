using System;
using System.Collections.Generic;

namespace ContohGoto
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {
                if (i==5) goto selesai;
                Console.WriteLine("i=" + i);
            }
            selesai:
            Console.ReadLine();
        }
    }
}