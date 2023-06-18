namespace UnitTest_Calculators_NUnit.Implementations.Bad2;

using Calculators.Implementations.Bad2;

public class Bad2SubtractUnitTests
{
    private Bad2Subtract _bad2Subtract;

    [SetUp]
    public void Setup()
    {
        _bad2Subtract = new Bad2Subtract();
    }

    [Test]
    [TestCase(0, 0, 0)]
    [TestCase(5, 7, -2)]
    public void GivenTwoNumbers_WhenTryingToSubtractThem_ThenYIsSubtractedFromX(int x, int y, int expectedResult)
    {
        // arrange

        // act
        var result = _bad2Subtract.Subtract(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
