namespace Calculators.Implementations.Bad2;

public class Bad2Divide : IDivide
{
    public long Divide(long x, long y)
    {
        long remainder = x;
        List<long> longs = new List<long>();
        while (remainder >= y)
        {
            longs.Add(1);
            remainder -= y;
        }

        long z = longs.Sum();
        return z;
    }
}
