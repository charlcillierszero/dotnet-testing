namespace Performance.Testing.Calculator;

using BenchmarkDotNet.Attributes;
using Calculators.Implementations.Bad;
using Calculators.Implementations.Good;

public partial class CalculatorBenchmarkTests
{
    private readonly GoodSubtract goodSubtract = new();

    private readonly BadSubtract badSubtract = new();

    [Benchmark]
    public long GoodSubtract() => goodSubtract.Subtract(x, y);

    [Benchmark]
    public long BadSubtract() => badSubtract.Subtract(x, y);
}
