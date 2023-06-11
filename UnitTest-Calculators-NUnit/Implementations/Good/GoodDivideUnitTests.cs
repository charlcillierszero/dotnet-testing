namespace UnitTest_Calculators_NUnit.Implementations.Bad;

using Calculators.Implementations.Good;

public class GoodDivideUnitTests
{
    private GoodDivide _goodDivide;

    [SetUp]
    public void Setup()
    {
        _goodDivide = new GoodDivide();
    }

    [Test]
    [TestCase(1, 1, 1)]
    [TestCase(10, 3, 3)]
    [TestCase(-10, 3, -3)]
    [TestCase(20, -9, -2)]
    [TestCase(-100, -10, 10)]
    public void GivenTwoNumbers_WhenTryingToDivideThem_ThenXIsDividedByY(int x, int y, int expectedResult)
    {
        // arrange

        // act
        var result = _goodDivide.Divide(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
