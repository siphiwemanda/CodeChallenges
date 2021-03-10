using Xunit;

namespace CodeChallenges.Tests
{
    public class RomanToIntegerTests
    {
        [Fact]
        public void RomanNumeralIReturnsOne()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("I");
            //Assert
            Assert.Equal(1, result);

        }

        [Fact]
        public void RomanNumeralVReturnsFive()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("V");
            //Assert
            Assert.Equal(5, result);

        }

        [Fact]
        public void RomanNumeralXReturns10()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("X");
            //Assert
            Assert.Equal(10, result);

        }

        [Fact]
        public void RomanNumeralLReturnsFifty()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("L");
            //Assert
            Assert.Equal(50, result);

        }

        [Fact]
        public void RomanNumeralCReturnsOneHundrad()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("C");
            //Assert
            Assert.Equal(100, result);

        }

        [Fact]
        public void RomanNumeralDReturnsFiveHundrad()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("D");
            //Assert
            Assert.Equal(500, result);

        }

        [Fact]
        public void RomanNumeralDReturnsOneThousand()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("M");
            //Assert
            Assert.Equal(1000, result);

        }

        [Fact]
        public void IIIIReturnsThree()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("III");
            //Assert
            Assert.Equal(3, result);

        }

        [Fact]
        public void IVReturnsFour()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("IV");
            //Assert
            Assert.Equal(4, result);

        }
        [Fact]
        public void IXReturnsNine()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("IX");
            //Assert
            Assert.Equal(9, result);

        }
        [Fact]
        public void LVIIIReturnsFiftyEight()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("LVIII");
            //Assert
            Assert.Equal(58, result);

        }
        [Fact]
        public void MCMXCIVReturnsFiftyOneHundradandNintyFour()
        {
            //Arrange
            var romans = new RomanToInteger();
            //Act
            var result = romans.RomanToInt("MCMXCIV");
            //Assert
            Assert.Equal(1994, result);

        }
    }
}