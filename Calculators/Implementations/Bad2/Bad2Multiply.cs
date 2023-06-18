namespace Calculators.Implementations.Bad2;

public class Bad2Multiply : IMultiply
{
    public long Multiply(long x, long y)
    {
        List<long> groupings = new List<long>();
        for (long i = 0; i < x; i++)
        {
            long grouping = 0;
            for (long j = 0; j < y; j++)
            {
                grouping += 1;
            }
            groupings.Add(grouping);
        }

        long z = groupings.Sum();
        return z;
    }
}
