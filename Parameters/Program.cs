using System;
using System.Collections.Generic;

namespace Parameters
{
    internal class Program
    {

        public static void FooMethod(int x, out int y, ref int z)
        {
            x = x * 10;
            y = x + 10;
            z = x + 100;
        }
        
        public static void Main(string[] args)
        {
            int a = 10;
            int b;
            int c = 10;
            FooMethod(a , out b , ref c);
            Console.WriteLine("Nilai a = {0}",a);
            Console.WriteLine("Nilai b = {0}",b);
            Console.WriteLine("Nilai c = {0}",c);
        }
    }
}