using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciCalculator calculator = new FibonacciCalculator();

            Console.Write("Enter a single number to generate Fibonacci sequence: ");
            if (int.TryParse(Console.ReadLine(), out int singleCount))
            {
                List<int> fibonacciSequence = calculator.GenerateFibonacci(singleCount);

                Console.WriteLine($"\nFibonacci sequence for {singleCount} terms:");
                foreach (int number in fibonacciSequence)
                {
                    Console.Write(number + " ");
                }

                int maxValue = fibonacciSequence.Count > 0 ? fibonacciSequence.Max() : 0;
                Console.WriteLine($"\nMaximum value: {maxValue}");
                Console.WriteLine($"Total iterations: {fibonacciSequence.Count}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("\nEnter the start of the range: ");
            if (!int.TryParse(Console.ReadLine(), out int start))
            {
                Console.WriteLine("Invalid start value.");
                return;
            }

            Console.Write("Enter the end of the range: ");
            if (!int.TryParse(Console.ReadLine(), out int end))
            {
                Console.WriteLine("Invalid end value.");
                return;
            }

            if (start > end || start < 1)
            {
                Console.WriteLine("Invalid range. Start must be >= 1 and <= End.");
                return;
            }

            FibonacciAnalyzer analyzer = new FibonacciAnalyzer();
            analyzer.AnalyzeRange(start, end);
        }
    }
}
