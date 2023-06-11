namespace Calculators.Implementations.Good;

public class GoodDivide : IDivide
{
    public long Divide(long x, long y)
        => y == 0 ? throw new ArithmeticException("Cannot divide by 0") : x / y;
}
