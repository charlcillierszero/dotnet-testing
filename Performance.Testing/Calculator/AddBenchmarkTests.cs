namespace Performance.Testing.Calculator;

using BenchmarkDotNet.Attributes;
using Calculators.Implementations.Bad;
using Calculators.Implementations.Good;

public partial class CalculatorBenchmarkTests
{
    private readonly GoodAdd goodAdd = new();

    private readonly BadAdd badAdd = new();

    [Benchmark]
    public long GoodAdd() => goodAdd.Add(x, y);

    [Benchmark]
    public long BadAdd() => badAdd.Add(x, y);
}
