using Xunit;

namespace CodeChallenges.Tests
{
    public class PalindromeNumberTest
    {
        [Fact]
        public void OneNumberIsAPalindrome()
        {
            //Arrange
            var palindrome = new PalindromeNumber();
            //Act
            var isPalindrome = palindrome.IsPalindrome(1);
            //Assert
            Assert.True(isPalindrome);
        }
        [Fact]
        public void NumberLessThanZeroAreNotPalindrome()
        {
            //Arrange
            var palindrome = new PalindromeNumber();
            //Act
            var isPalindrome = palindrome.IsPalindrome(-121);
            //Assert
            Assert.False(isPalindrome);
        }

        [Fact]
        public void NumberAboveTenCanBePalindrome()
        {
            //Arrange
            var palindrome = new PalindromeNumber();
            //Act
            var isPalindrome = palindrome.IsPalindrome(11);
            //Assert
            Assert.True(isPalindrome);
        }
        [Fact]
        public void NumberAboveTenMayNotBeAPalindrome()
        {
            //Arrange
            var palindrome = new PalindromeNumber();
            //Act
            var isPalindrome = palindrome.IsPalindrome(23);
            //Assert
            Assert.False(isPalindrome);
        }
        [Fact]
        public void PalindromeNumberInTheHundreds()
        {
            //Arrange
            var palindrome = new PalindromeNumber();
            //Act
            var isPalindrome = palindrome.IsPalindrome(121);
            //Assert
            Assert.True(isPalindrome);
        }
        [Fact]
        public void PalindromeNumberInTheThousands()
        {
            //Arrange
            var palindrome = new PalindromeNumber();
            //Act
            var isPalindrome = palindrome.IsPalindrome(10201);
            //Assert
            Assert.True(isPalindrome);
        }
        [Fact]
        public void NumbersThanEndInZeroAreNotPalindrome()
        {
            //Arrange
            var palindrome = new PalindromeNumber();
            //Act
            var isPalindrome = palindrome.IsPalindrome(10);
            //Assert
            Assert.False(isPalindrome);
        }
    }
}