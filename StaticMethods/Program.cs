using System;
using System.Collections.Generic;

namespace StaticMethods
{
    internal class Program
    {
        static void F()
        {
            Console.WriteLine("F()");
        }

        static void F(object o)
        {
            Console.WriteLine("F(object)");
        }

        static void F(ref int value)
        {
            Console.WriteLine("F (ref int)");
        }

        static void F(int a, int b)
        {
            Console.WriteLine("F(int , int)");
        }

        static void F(int[] values)
        {
            Console.WriteLine("F(int[])");
        }
        
        public static void Main(string[] args)
        {
            F();
            F(1);
            int i = 10;
            F(ref i);
            F((object)1);
            F(1,2);
            F( new int[] {1,2,3});
        }
    }
}