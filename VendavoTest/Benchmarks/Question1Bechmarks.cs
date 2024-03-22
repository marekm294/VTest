using BenchmarkDotNet.Attributes;

namespace VendavoTest.Benchmarks;

[MemoryDiagnoser(false)]
public class Question1Bechmarks
{
    public int[] Input { get; } = { 1, 2, 3 };

    [Benchmark]
    public int OldSolution()
    {
        return Question1.Solution(Input);
    }
}