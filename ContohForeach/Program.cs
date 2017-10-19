using System;
using System.Collections.Generic;

namespace ContohForeach
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] drives = System.Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                Console.WriteLine("drive" + drive);
            }
            Console.ReadLine();

            int[] numbers = {1, 2, 3, 4, 5, 6};
            foreach (int i in numbers)
            {
                Console.WriteLine("The Value of i ={0}",i);
            }
        }
    }
}