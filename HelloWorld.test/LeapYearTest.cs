namespace HelloWorld.test;

public class LeapYearTest
{
    [Fact]
    public void IsYearLeapTest()
    {
        //arrange
        var leap = new LeapYear();

        //act
        var result = leap.IsLeapYear(1600);
        var result2 = leap.IsLeapYear(1900);


        //assert
        result.Should().Be(true);
        result2.Should().Be(false);

    }
}