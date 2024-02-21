using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace ParallelForDemo
{
    public class ParallelForBenchMark
    {

        [Benchmark]
        public void ParallelNoFor()
        {
            Console.WriteLine("C# For Loop");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        [Benchmark]
        public void ParallelFor()
        {
            Console.WriteLine("C# Parallel For Loop");
            Parallel.For(1, 101, number => {
                Console.WriteLine(number);
            });
        }
 
    }
}