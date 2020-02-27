using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenchmarkOrderbyvsSort
{
    [RPlotExporter]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class SortingBenchmark
    {
        private List<int> list1;
        private List<int> list2;

        [Params(100, 10000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            list1 = new List<int>();
            list2 = new List<int>();

            Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < N; i++)
            {
                list1.Add(rand1.Next());
            }

            Random rand2 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < N; i++)
            {                                
                list2.Add(rand2.Next());
            }
        }

        [Benchmark]
        public void OrderbyList()
        {
            var result = list1.OrderBy(x => x).ToList();
        }

        [Benchmark]
        public void SortList()
        {
            list2.Sort();
        }
    }
}
