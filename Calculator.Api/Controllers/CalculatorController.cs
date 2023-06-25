namespace Calculator.Api.Controllers;

using Microsoft.AspNetCore.Mvc;
using Calculators;
using Calculators.Implementations.Good;
using Calculators.Implementations.Bad;

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

    [HttpGet]
    [Route("GoodAdd")]
    public long GoodAdd(long x, long y) => goodCalculator.Add(x, y);

    [HttpGet]
    [Route("BadAdd")]
    public long BadAdd(long x, long y) => badCalculator.Add(x, y);

    [HttpGet]
    [Route("GoodSubtract")]
    public long GoodSubtract(long x, long y) => goodCalculator.Subtract(x, y);

    [HttpGet]
    [Route("BadSubtract")]
    public long BadSubtract(long x, long y) => badCalculator.Subtract(x, y);

    [HttpGet]
    [Route("GoodMultiply")]
    public long GoodMultiply(long x, long y) => goodCalculator.Multiply(x, y);

    [HttpGet]
    [Route("BadMultiply")]
    public long BadMultiply(long x, long y) => badCalculator.Multiply(x, y);

    [HttpGet]
    [Route("GoodDivide")]
    public long GoodDivide(long x, long y) => goodCalculator.Divide(x, y);

    [HttpGet]
    [Route("BadDivide")]
    public long BadDivide(long x, long y) => badCalculator.Divide(x, y);
}