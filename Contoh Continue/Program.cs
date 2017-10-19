using System;
using System.Collections.Generic;

namespace ContohContinue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i=0 ; i<10; i++)
            {
                if (i==5) continue;
                Console.WriteLine("i= " + i);
            }
            Console.ReadLine();
        }
    }
}