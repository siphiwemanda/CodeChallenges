using Xunit;

namespace CodeChallenges.Tests
{
    public class AddBinaryTest
    {
        [Fact]
        public void BinaryStringOnePlusZeroIsOne()
        { 
            //Arrange
            var addBinary = new AddBinary();

            //Act
            var binaryMath = addBinary.Add("1","0");

            //Assert
            
            Assert.Equal("1", binaryMath);
        }
        [Fact]
        public void BinaryStringFourPlusZeroIsFour()
        { 
            //Arrange
            var addBinary = new AddBinary();

            //Act
            var binaryMath = addBinary.Add("0100","0");

            //Assert
            
            Assert.Equal("0100", binaryMath);
        }
    
    }
}