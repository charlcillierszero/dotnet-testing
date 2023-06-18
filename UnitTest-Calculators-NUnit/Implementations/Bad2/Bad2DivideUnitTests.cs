namespace UnitTest_Calculators_NUnit.Implementations.Bad2;

using Calculators.Implementations.Bad2;

public class Bad2DivideUnitTests
{
    private Bad2Divide _bad2Divide;

    [SetUp]
    public void Setup()
    {
        _bad2Divide = new Bad2Divide();
    }

    [Test]
    [TestCase(1, 1, 1)]
    [TestCase(10, 3, 3)]
    public void GivenTwoNumbers_WhenTryingToDivideThem_ThenXIsDividedByY(int x, int y, int expectedResult)
    {
        // arrange

        // act
        var result = _bad2Divide.Divide(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
