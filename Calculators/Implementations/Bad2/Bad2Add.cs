namespace Calculators.Implementations.Bad2;

public class Bad2Add : IAdd
{
    public long Add(long x, long y)
    {
        List<long> longs = new List<long>();

        if (x > 0)
        {
            for (long i = 0; i < x; i++)
            {
                longs.Add(1);
            }
        }

        if (y > 0)
        {
            for (long i = 0; i < y; i++)
            {
                longs.Add(1);
            }
        }

        long z = longs.Sum();
        return z;
    }
}
