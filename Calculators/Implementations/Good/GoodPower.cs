namespace Calculators.Implementations.Good;

public class GoodPower : IPower
{
    public long Power(long x, long y) => (long)Math.Pow(x, y);
}
