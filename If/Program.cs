using System;
using System.Collections.Generic;

namespace If
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Masukan Nilai X :");
            int x = int.Parse(Console.ReadLine());
            
            Console.Write("Masukan Nilai Y : ");
            int y = int.Parse(Console.ReadLine());

            if (y !=0)
            {
                double hasil = x / y;
                Console.WriteLine("Hasil Pembagian X / Y  = {0}",hasil);
            }
            Console.ReadLine();
        }
    }
}