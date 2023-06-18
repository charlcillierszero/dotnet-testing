namespace UnitTest_Calculators_NUnit.Implementations.Bad2;

using Calculators.Implementations.Bad2;

public class Bad2MultiplyUnitTests
{
    private Bad2Multiply _bad2Multiply;

    [SetUp]
    public void Setup()
    {
        _bad2Multiply = new Bad2Multiply();
    }

    [Test]
    [TestCase(0, 0, 0)]
    [TestCase(4, 6, 24)]
    public void GivenTwoNumbers_WhenTryingToMultiplyThem_ThenTheyAreMultipliedTogether(int x, int y, int expectedResult)
    {
        // arrange

        // act
        var result = _bad2Multiply.Multiply(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
