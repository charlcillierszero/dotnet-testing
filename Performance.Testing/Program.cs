namespace Performance.Testing;

using BenchmarkDotNet.Running;
using Performance.Testing.Calculator;

public class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<CalculatorBenchmarkTests>();
    }
}