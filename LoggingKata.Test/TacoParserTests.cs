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
        [InlineData("34.992219, -86.841402, Taco Bell Ardmore...", -86.841402)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            var longitude = new TacoParser();//Arrange

            var actual = longitude.Parse(line).Location.Longitude;//Act

            Assert.Equal(expected, actual);//Assert
        }


        [Theory]//TODO: Create a test ShouldParseLatitude
        [InlineData("30.731386, -86.566652, Taco Bell Crestvie...", -86.566652)]
        public void ShouldParseLatitude(string line, double expected)
        {
            var latitude = new TacoParser();

            var actual = latitude.Parse(line).Location.Latitude;

            Assert.Equal(expected, actual);

        }

    }
}
