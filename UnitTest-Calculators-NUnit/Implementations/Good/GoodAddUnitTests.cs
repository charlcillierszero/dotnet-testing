namespace UnitTest_Calculators_NUnit.Implementations.Bad;

using Calculators.Implementations.Good;

public class GoodAddUnitTests
{
    private GoodAdd _goodAdd;

    [SetUp]
    public void Setup()
    {
        _goodAdd = new GoodAdd();
    }

    [Test]
    [TestCase(0, 0, 0)]
    [TestCase(5, 7, 12)]
    [TestCase(-11, -13, -24)]
    [TestCase(-5, 7, 2)]
    [TestCase(7, -5, 2)]
    public void GivenTwoNumbers_WhenTryingToAddThem_ThenTheyAreAddedTogether(int x, int y, int expectedResult)
    {
        // arrange

        // act
        var result = _goodAdd.Add(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
