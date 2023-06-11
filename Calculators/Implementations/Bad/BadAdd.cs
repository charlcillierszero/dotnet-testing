namespace Calculators.Implementations.Bad;

public class BadAdd : IAdd
{
    public long Add(long x, long y)
    {
        List<long> longs = new List<long>();
        for (long i = 0; i < Math.Abs(x); i++)
        {
            longs.Add(x < 0 ? -1 : 1);
        }

        for (long i = 0; i < Math.Abs(y); i++)
        {
            longs.Add(y < 0 ? -1 : 1);
        }

        long z = longs.Sum();
        return z;
    }
}
