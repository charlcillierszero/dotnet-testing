namespace UnitTest_Calculators_NUnit.Implementations.Bad;

using Calculators.Implementations.Bad;

public class BadSubtractUnitTests
{
    private BadSubtract _badSubtract;

    [SetUp]
    public void Setup()
    {
        _badSubtract = new BadSubtract();
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
        var result = _badSubtract.Subtract(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
