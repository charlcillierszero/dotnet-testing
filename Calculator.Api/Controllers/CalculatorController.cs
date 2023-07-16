namespace Calculator.Api.Controllers;

using Calculators;
using Calculators.Implementations.Bad;
using Calculators.Implementations.Good;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly Calculator goodCalculator;

    private readonly Calculator badCalculator;

    public CalculatorController()
    {
        goodCalculator = new Calculator(new GoodAdd(), new GoodSubtract(), new GoodMultiply(), new GoodDivide());
        badCalculator = new Calculator(new BadAdd(), new BadSubtract(), new BadMultiply(), new BadDivide());
    }

    [HttpGet("good-add")]
    public long GoodAdd(long x, long y) => goodCalculator.Add(x, y);

    [HttpGet("bad-add")]
    public long BadAdd(long x, long y) => badCalculator.Add(x, y);

    [HttpGet("good-subtract")]
    public long GoodSubtract(long x, long y) => goodCalculator.Subtract(x, y);

    [HttpGet("bad-subtract")]
    public long BadSubtract(long x, long y) => badCalculator.Subtract(x, y);

    [HttpGet("good-multiply")]
    public long GoodMultiply(long x, long y) => goodCalculator.Multiply(x, y);

    [HttpGet("bad-multiply")]
    public long BadMultiply(long x, long y) => badCalculator.Multiply(x, y);

    [HttpGet("good-divide")]
    public long GoodDivide(long x, long y) => goodCalculator.Divide(x, y);

    [HttpGet("bad-divide")]
    public long BadDivide(long x, long y) => badCalculator.Divide(x, y);
}