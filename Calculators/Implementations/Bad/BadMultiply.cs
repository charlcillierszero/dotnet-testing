namespace Calculators.Implementations.Bad;

public class BadMultiply : IMultiply
{
    public long Multiply(long x, long y)
    {
        bool isPositive = false;
        if ((x > 0 && y > 0) || (x < 0 && y < 0))
        {
            isPositive = true;
        }

        List<long> groupings = new List<long>();
        for (long i = 0; i < Math.Abs(x); i++)
        {
            long grouping = 0;
            for (long j = 0; j < Math.Abs(y); j++)
            {
                grouping += 1;
            }
            groupings.Add(grouping);
        }

        long z = groupings.Sum();

        if (!isPositive)
        {
            z *= -1;
        }

        return z;
    }
}
