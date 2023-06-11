namespace Calculators.Implementations.Bad;

public class BadDivide : IDivide
{
    public long Divide(long x, long y)
    {
        if (y == 0)
        {
            throw new ArithmeticException("Cannot divide by 0");
        }

        bool isPositive = false;
        if ((x > 0 && y > 0) || (x < 0 && y < 0))
        {
            isPositive = true;
        }

        long remainder = Math.Abs(x);
        long safeY = Math.Abs(y);
        List<long> longs = new List<long>();
        while (remainder >= safeY)
        {
            longs.Add(1);
            remainder -= safeY;
        }

        long z = longs.Sum();
        if (!isPositive)
        {
            z *= -1;
        }

        return z;
    }
}
