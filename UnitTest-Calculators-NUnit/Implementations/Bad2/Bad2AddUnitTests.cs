namespace UnitTest_Calculators_NUnit.Implementations.Bad2;

using Calculators.Implementations.Bad2;

public class Bad2AddUnitTests
{
    private Bad2Add _bad2Add;

    [SetUp]
    public void Setup()
    {
        _bad2Add = new Bad2Add();
    }

    [Test]
    [TestCase(0, 0, 0)]
    [TestCase(5, 7, 12)]
    public void GivenTwoNumbers_WhenTryingToAddThem_ThenTheyAreAddedTogether(int x, int y, int expectedResult)
    {
        // arrange

        // act
        var result = _bad2Add.Add(x, y);

        // assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
