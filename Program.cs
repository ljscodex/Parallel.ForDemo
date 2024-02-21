using System;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ParallelForDemo;

namespace Net_Tests
{

    [MemoryDiagnoser]
    [RankColumn]
    
    class Program
    {

        static void Main(string[] args)        
        {
            // if you wants to execute all benchmarks
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            // if you wants to execute just the ParallelForBenchMark class
           //var summary = BenchmarkRunner.Run<ParallelForBenchMark>();

        }
    }


}
