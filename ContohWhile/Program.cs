using System;
using System.Collections.Generic;

namespace ContohWhile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("While");
            int i = 0;
            while (i < 20)
            {
                if (i %2 == 0)
                {   
                    Console.WriteLine("Angka Genap : " + i);
                }
                i += 1;
            }
            Console.ReadLine();
        }
    }
}