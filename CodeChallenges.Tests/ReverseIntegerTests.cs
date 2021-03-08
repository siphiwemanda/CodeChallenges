using System;
using Xunit;

namespace CodeChallenges.Tests
{
    public class ReverseIntegerTests
    {
        [Fact]
        public void OneNumberReturnsNumber()
        {
           //Arrange
            var calculation = new ReverseInteger();
            //act
            var reversed = calculation.Reverse(1);
            //Assert
            Assert.Equal(1,reversed);

        }
        [Fact]
        public void TwoNumbersAreReveresed()
        {
            //Arrange
            var calculation = new ReverseInteger();
            //act
            var reversed = calculation.Reverse(12);
            //Assert
            Assert.Equal(21,reversed);

        }
        [Fact]
        public void ThreeNumbersAreReveresed()
        {
            //Arrange
            var calculation = new ReverseInteger();
            //act
            var reversed = calculation.Reverse(123);
            //Assert
            Assert.Equal(321,reversed);

        }
        [Fact]
        public void ZeroAtTheEndDoesNotCount()
        {
            //Arrange
            var calculation = new ReverseInteger();
            //act
            var reversed = calculation.Reverse(120);
            //Assert
            Assert.Equal(21,reversed);
        }
        [Fact]
        public void ThreeMinusNumbersReturnRevresedAndStillMinus()
        {
            //Arrange
            var calculation = new ReverseInteger();
            //act
            var reversed = calculation.Reverse(-123);
            //Assert
            Assert.Equal(-321,reversed);
        }
        [Fact]
        public void NumberReturnedIsNotHigherThanThe32BitIntegerRange()
        {
            //Arrange
            var calculation = new ReverseInteger();
            //act
            var reversed = calculation.Reverse(1534236469);
            //Assert
            Assert.Equal(0,reversed);
        }
        [Fact]
        public void NumberReturnedIsNotLowerThanThe32BitIntegerRange()
        {
            //Arrange
            var calculation = new ReverseInteger();
            //Act
            var reversed = calculation.Reverse(-1147483648);
            //Assert
            Assert.Equal(0,reversed);
        }
    }
}
