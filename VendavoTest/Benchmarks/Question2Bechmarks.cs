using BenchmarkDotNet.Attributes;

namespace VendavoTest.Benchmarks;

[MemoryDiagnoser]
public class Question2Bechmarks
{

    [Benchmark]
    public int Solution()
    {
        return Question2.Solution(9, [5, 3, 8, 1, 8, 7, 7, 6]);
    }
}