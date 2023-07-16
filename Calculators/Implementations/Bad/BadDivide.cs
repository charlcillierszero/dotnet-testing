namespace Calculators.Implementations.Bad;

public class BadDivide : IDivide
{
    public long Divide(long x, long y)
    {
        if (y == 0)
        {
            throw new ArithmeticException("Cannot divide by 0");
        }

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
