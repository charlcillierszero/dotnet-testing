namespace UnitTest_Calculators_NUnit.Implementations.Bad;

using Calculators.Implementations.Good;

public class GoodMultiplyUnitTests
{
    private GoodMultiply _goodMultiply;

    [SetUp]
    public void Setup()
    {
        _goodMultiply = new GoodMultiply();
    }

    [Test]
    [TestCase(0, 0, 0)]
    [TestCase(4, 6, 24)]
    [TestCase(-5, -5, 25)]
    [TestCase(-5, 7, -35)]
    [TestCase(7, -5, -35)]
    public void GivenTwoNumbers_WhenTryingToMultiplyThem_ThenTheyAreMultipliedTogether(int x, int y, int expectedResult)
    {
        // arrange

        // act
        var result = _goodMultiply.Multiply(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
