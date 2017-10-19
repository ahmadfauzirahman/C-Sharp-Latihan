using System;
using System.Collections.Generic;

namespace ContohSwitch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                {
                    Console.WriteLine("SEKARANG HARI MINGGU");
                    break;
                }
                case DayOfWeek.Monday:
                {
                    Console.WriteLine("SEKARANG HARI SENIN");
                    break;
                }
                case DayOfWeek.Tuesday:
                {
                    Console.WriteLine("SEKARANG HARI SELASA");
                    break;
                }
                default:
                {
                    Console.WriteLine("SEKARANG HARI APA YA ?");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}