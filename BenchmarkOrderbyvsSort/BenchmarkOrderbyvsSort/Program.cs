using BenchmarkDotNet.Running;
using System;

namespace BenchmarkOrderbyvsSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SortingBenchmark>();
            Console.ReadKey();
        }
    }
}
