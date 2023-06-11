namespace Calculators.Implementations.Bad;

public class BadSubtract : ISubtract
{
    public long Subtract(long x, long y)
    {
        List<long> longs = new List<long>();
        for (long i = 0; i < Math.Abs(x); i++)
        {
            longs.Add(x < 0 ? -1 : 1);
        }

        for (long i = 0; i < Math.Abs(y); i++)
        {
            longs.Add(y < 0 ? 1 : -1);
        }

        long z = longs.Sum();
        return z;
    }
}
