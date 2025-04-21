using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class FibonacciAnalyzer
    {
        private FibonacciCalculator calculator = new FibonacciCalculator();

        public void AnalyzeRange(int start, int end)
        {
            List<int> numbers = new List<int>();
            List<int> maxValues = new List<int>();
            List<int> iterationCounts = new List<int>();

            for (int i = start; i <= end; i++)
            {
                var sequence = calculator.GenerateFibonacci(i);
                int max = sequence.Count > 0 ? sequence.Max() : 0;
                int iterations = sequence.Count;

                numbers.Add(i);
                maxValues.Add(max);
                iterationCounts.Add(iterations);
            }

            Console.WriteLine("\nResults:");
            Console.WriteLine("Number\tMax Value\tIterations");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"{numbers[i]}\t{maxValues[i]}\t\t{iterationCounts[i]}");
            }
        }
    }
}
