using System;
using System.Collections.Generic;

namespace KondisidanAksi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (DateTime.Now.Hour > 7 )
            {
                Console.WriteLine("Saat Cuci Kaki Dan Bobo!!!!");
                Console.WriteLine("Selamat Malam");
            }
            Console.ReadLine();
        }
    }
}