namespace Calculators;

public class Calculator
{
    private readonly IAdd _add;
    private readonly ISubtract _subtract;
    private readonly IMultiply _multiply;
    private readonly IDivide _divide;

    public Calculator(IAdd add, ISubtract subtract, IMultiply multiply, IDivide divide)
        => (_add, _subtract, _multiply, _divide) = (add, subtract, multiply, divide);

    public long Add(long x, long y) => _add.Add(x, y);
    public long Subtract(long x, long y) => _subtract.Subtract(x, y);
    public long Multiply(long x, long y) => _multiply.Multiply(x, y);
    public long Divide(long x, long y) => _divide.Divide(x, y);
}
