using System;
using System.Collections.Generic;

namespace ContohReturn
{
    internal class Program
    {
        public static void FungsiB()
        {
            Console.WriteLine("FungsiB");
            Console.WriteLine("Akan menjalankan return ...");
            return;
        }
        public static void FungsiA()
        {
            Console .WriteLine("FungsiA");
            Console.WriteLine("Akan memanggil FungsiB");
            FungsiB();
            Console.WriteLine("Melanjutkan perintah Fungsi A berikutnya");
        }
        public static void Main(string[] args)
        {
            FungsiA();
            Console.ReadLine();
        }
    }
}