using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDay4Assignmnet4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; 

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 20);
            }

            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:F2}");

            Console.ReadKey();
        }
    }
}
