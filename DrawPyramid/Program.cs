using System;
using System.Collections.Generic;

namespace DrawPyramid
{
    internal class Program
    {
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <=n ; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2*i-1; k++)
                {
                    Console.Write("*"+ " ");
                }
                
                Console.WriteLine();
            }
        }
        
        public static void Main(string[] args)
        {
            DrawPyramid(5);
        }
    }
}