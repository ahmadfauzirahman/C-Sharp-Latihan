using System;
using System.Collections.Generic;

namespace ContohFor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] drives = System.Environment.GetLogicalDrives();
            for (int i=0; i<drives.Length; i++)
            {
                Console.WriteLine("drive " + drives[i]);
            }
            Console.ReadLine();  
        }
    }
}