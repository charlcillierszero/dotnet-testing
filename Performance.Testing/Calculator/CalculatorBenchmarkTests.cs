namespace Performance.Testing.Calculator;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80)]
[MemoryDiagnoser]
[DisassemblyDiagnoser]
public partial class CalculatorBenchmarkTests
{
    [Params(5_000L)]
    public long x;

    [Params(5_000L)]
    public long y;

    [GlobalSetup]
    public void Setup()
    {

    }
}
