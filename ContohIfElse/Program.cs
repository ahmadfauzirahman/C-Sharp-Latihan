using System;
using System.Collections.Generic;

namespace ContohIfElse
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Masukkan nilai x : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai y : ");
            int y = int.Parse(Console.ReadLine());
            if (y!=0)
            {
                double hasil = x/y;
                Console.WriteLine("Hasil pembagian x/y = {0}",hasil);
            }
            else
            {
                Console.WriteLine("Error: y bernilai 0");
            }
            Console.ReadLine();
        }
    }
}