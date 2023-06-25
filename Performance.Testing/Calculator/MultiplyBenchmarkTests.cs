namespace Performance.Testing.Calculator;

using BenchmarkDotNet.Attributes;
using Calculators.Implementations.Bad;
using Calculators.Implementations.Good;

public partial class CalculatorBenchmarkTests
{
    private readonly GoodMultiply goodMultiply = new();

    private readonly BadMultiply badMultiply = new();

    [Benchmark]
    public long GoodMultiply() => goodMultiply.Multiply(x, y);

    [Benchmark]
    public long BadMultiply() => badMultiply.Multiply(x, y);
}
