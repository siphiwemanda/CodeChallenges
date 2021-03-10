namespace CodeChallenges
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int number)
        {
            return number switch
            {
                < 0 => false,
                < 10 => true,
                _ => number % 10 != 0 && Reverse(number)
            };
        }

        private bool Reverse(int number)
        {
            var n = number;
            var newNumber = 0;
            do
            {
                newNumber = (newNumber * 10) + (n % 10);

                n /= 10;
            } while (n > newNumber);

            return n == newNumber|| n == newNumber / 10;
        }
    }
}