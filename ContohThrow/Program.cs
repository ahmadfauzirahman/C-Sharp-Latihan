using System;
using System.Collections.Generic;

namespace ContohThrow
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                 Console.Write("Ketik Nama Anda");
                String nama = Console.ReadLine();
                if (nama != "fauzi") 
                    throw new System.ApplicationException("Nama Tidak Dikenali");
                    Console.Write("Selamat, Anda Masuk Orang terkenal :)");
            }
            catch (ApplicationException e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }
            Console.ReadLine();
        }
    }
}