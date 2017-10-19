using System;
using System.Collections.Generic;

namespace KasusUmur
{
    internal class Program
    {
        public static void Main()
        {
            int day;
            int month;
            int year;

            Console.Out.WriteLine("Menghitung Umur");
            Console.Out.WriteLine("============================");
            try
            {
                Console.Out.Write("Masukkan Tanggal: ");
                day = Convert.ToInt32(Console.In.ReadLine());
                Console.Out.Write("Masukkan Bulan : ");
                month = Convert.ToInt32(Console.In.ReadLine());
                Console.Out.Write("Masukkan Tahun : ");
                year = Convert.ToInt32(Console.In.ReadLine());
                DateTime birthDate = new DateTime(year, month, day);
                DateTime today = DateTime.Now;
                TimeSpan age = today.Subtract(birthDate);
                Console.Out.WriteLine(
                    "Saat ini umur anda adalah: {0} hari, {1} jam, " +
                    "{2} minutes.", age.Days, age.Hours, age.Minutes);
            }
            catch (FormatException e)
            {
                Console.Out.WriteLine("Data tanggal, bulan dan tahun harus berupa angka.");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Terjadi Kesalahan :" + e.Message);
            }
        }
    }
}