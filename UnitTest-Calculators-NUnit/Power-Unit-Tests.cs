namespace UnitTest_Calculators;

using Calculators.Implementations.TDD;
using Calculators.Interfaces;

public class Tests
{
    private IPower power;

    [SetUp]
    public void Setup()
    {
        power = new TddPower();
    }

    [Test]
    [TestCase(2, 2, 4)]
    [TestCase(-2, 2, 4)]
    [TestCase(3, 3, 27)]
    public void Power(long x, long y, long expectedResult)
    {
        // arrange

        // act
        var result = power.Power(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}