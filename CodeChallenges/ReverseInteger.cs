using System;

namespace CodeChallenges
{
    public class ReverseInteger
    {
        public int Reverse(int numbers)
        {

            var n = Math.Abs(numbers);
            var newNumber = 0;
            while (n > 0)
            {
                newNumber = (newNumber * 10) + (n % 10);
                n /= 10;
            }

            if (numbers < 0)
            {
                newNumber = 0 - newNumber;
            }

            return newNumber;
        }
    }
}