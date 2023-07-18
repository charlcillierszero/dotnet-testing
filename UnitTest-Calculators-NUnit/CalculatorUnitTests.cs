using Calculators;
using Calculators.Implementations.Good;
using Calculators.Interfaces;
using Moq;

namespace UnitTest_Calculators_NUnit.Implementations.Bad;

public class CalculatorUnitTests
{
    private Mock<IAdd> _add;
    private Mock<ISubtract> _sub;
    private Mock<IMultiply> _mul;
    private Mock<IDivide> _div;

    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _add = new Mock<IAdd>();
        _sub = new Mock<ISubtract>();
        _mul = new Mock<IMultiply>();
        _div = new Mock<IDivide>();
    }

    [Test]
    public void GivenAdd_WhenXAndYArePassedIn_ThenTheyArePassedToInjectedImplementation()
    {
        // arrange
        var expected = -555L;
        _add.Setup(implementation => implementation.Add(It.IsAny<long>(), It.IsAny<long>())).Returns(expected);
        _calculator = new Calculator(_add.Object, _sub.Object, _mul.Object, _div.Object);

        // act
        var actual = _calculator.Add(0, 0);

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
