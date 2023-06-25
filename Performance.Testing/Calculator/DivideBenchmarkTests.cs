namespace Performance.Testing.Calculator;

using BenchmarkDotNet.Attributes;
using Calculators.Implementations.Bad;
using Calculators.Implementations.Good;

public partial class CalculatorBenchmarkTests
{
    private readonly GoodDivide goodDivide = new();

    private readonly BadDivide badDivide = new();

    [Benchmark]
    public long GoodDivide() => goodDivide.Divide(x, y);

    [Benchmark]
    public long BadDivide() => badDivide.Divide(x, y);
}
