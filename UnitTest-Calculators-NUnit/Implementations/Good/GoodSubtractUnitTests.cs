namespace UnitTest_Calculators_NUnit.Implementations.Bad;

using Calculators.Implementations.Good;

public class GoodSubtractUnitTests
{
    private GoodSubtract _goodSubtract;

    [SetUp]
    public void Setup()
    {
        _goodSubtract = new GoodSubtract();
    }

    [Test]
    [TestCase(0, 0, 0)]
    [TestCase(5, 7, -2)]
    [TestCase(-11, -13, 2)]
    [TestCase(-5, 7, -12)]
    [TestCase(7, -5, 12)]
    public void GivenTwoNumbers_WhenTryingToSubtractThem_ThenYIsSubtractedFromX(int x, int y, int expectedResult)
    {
        // arrange

        // act
        var result = _goodSubtract.Subtract(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
