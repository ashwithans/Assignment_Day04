using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDay4Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write("\n" +a);
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.ReadKey();
        }
    }
}
