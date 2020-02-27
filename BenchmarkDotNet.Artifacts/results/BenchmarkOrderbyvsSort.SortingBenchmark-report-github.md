``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i5-3340M CPU 2.70GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-BNMBRB : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|      Method |     N |           Mean |        Error |        StdDev |         Median |
|------------ |------ |---------------:|-------------:|--------------:|---------------:|
| **OrderbyList** |   **100** |     **8,565.5 ns** |    **161.00 ns** |     **150.60 ns** |     **8,496.7 ns** |
|    SortList |   100 |       541.5 ns |     10.26 ns |      10.08 ns |       537.1 ns |
| **OrderbyList** | **10000** | **2,089,497.3 ns** | **72,273.86 ns** | **211,966.73 ns** | **1,996,932.0 ns** |
|    SortList | 10000 |   102,688.4 ns |  2,053.79 ns |   3,806.82 ns |   100,872.8 ns |
