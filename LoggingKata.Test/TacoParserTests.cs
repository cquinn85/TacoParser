using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expectedLongitude)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var parser = new TacoParser();//contains the parse method
            //Act
            var tacoBell = parser.Parse(line);
            //Assert
            Assert.Equal(expectedLongitude, tacoBell.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expectedLatitude)
        {
           
            //Arrange: prepare the code I need in order to test the method I want to test
            var parser = new TacoParser();//contains the parse method

            //Act: Call that method I want to test
            var tacoBell = parser.Parse(line);

            //Assert: I compare against a known constant(answer).
            Assert.Equal(expectedLatitude, tacoBell.Location.Latitude);
        }
    }
}
