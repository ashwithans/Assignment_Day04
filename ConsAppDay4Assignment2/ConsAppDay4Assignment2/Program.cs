using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDay4Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 natural numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n\nFirst 10 even natural numbers using while loop:");
            int j = 2; 
            int countEven = 0;

            while (countEven < 10)
            {
                Console.Write($"{j} ");
                j += 2;
                countEven++;
            }

            Console.WriteLine("\n\nFirst 10 odd natural numbers using do-while loop:");
            int k = 1; 
            int countOdd = 0;

            do
            {
                Console.Write($"{k} ");
                k += 2;
                countOdd++;
            } while (countOdd < 10);

            Console.ReadKey();
        }
    }
}
