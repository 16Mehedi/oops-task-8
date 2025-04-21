using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class FibonacciCalculator
    {
        public List<int> GenerateFibonacci(int count)
        {
            List<int> sequence = new List<int>();

            if (count <= 0) return sequence;
            if (count >= 1) sequence.Add(1);
            if (count >= 2) sequence.Add(2);

            for (int i = 2; i < count; i++)
            {
                int next = sequence[i - 1] + sequence[i - 2];
                sequence.Add(next);
            }

            return sequence;
        }
    }
}
