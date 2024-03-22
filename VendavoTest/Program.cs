using BenchmarkDotNet.Running;
using VendavoTest.Benchmarks;

namespace VendavoTest;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Question1Bechmarks>();
        BenchmarkRunner.Run<Question2Bechmarks>();
    }
}
