using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDay4Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Again:

            Console.Write("Enter your exam score as a percentage: ");
            int examScore = int.Parse(Console.ReadLine());

            
            if (examScore >= 90)
            {
                Console.WriteLine("Your letter grade: A");
            }
            else if (examScore >= 80)
            {
                Console.WriteLine("Your letter grade: B");
            }
            else if (examScore >= 70)
            {
                Console.WriteLine("Your letter grade: C");
            }
            else if (examScore >= 60)
            {
                Console.WriteLine("Your letter grade: D");
            }
            else
            {
                Console.WriteLine("Your letter grade: F");
            }
            goto Again;
        }
    }
}
