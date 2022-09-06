namespace HelloWorld.test;

public class LeapYearTest
{
    [Fact]
    public void IsYearLeapTest()
    {
        //arrange
        var leapYearInt1 = 1600;
        var leapYearInt2 = 1900;

        //act
        var result = HelloWorld.LeapYear.IsLeapYear(leapYearInt1);
        var result2 = HelloWorld.LeapYear.IsLeapYear(leapYearInt2);


        //assert
        result.Should().Be(true);
        result2.Should().Be(false);

    }


    [Fact]
    public void IsYearLeapTest2()
    {
        //arrange
        var leapYearInt1 = 1600;
        var leapYearInt2 = 1900;

        //act
        var result = HelloWorld.LeapYear.IsLeapYear2(leapYearInt1);
        var result2 = HelloWorld.LeapYear.IsLeapYear2(leapYearInt2);


        //assert
        result.Should().Be(true);
        result2.Should().Be(false);

    }
}