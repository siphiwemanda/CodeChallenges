using System;

namespace CodeChallenges
{
    public class ReverseInteger
    {
        public int Reverse(int numbers)
        {
            return numbers > 0 ? PositiveCalculation(numbers) : NegativeCalculation(numbers);
        }

        private int NegativeCalculation(int numbers)
        {
            var n = numbers;
            var newNumber = 0;
            while (n < 0)
            {
                if ((int.MinValue - n % 10) / 10 > newNumber)
                {
                    return 0;
                }

                newNumber = (newNumber * 10) + (n % 10);

                n /= 10;
            }
            return newNumber;
        }

        private int PositiveCalculation(int numbers)
        {
            var n = numbers;
            var newNumber = 0;
            while (n > 0)
            {
                if ((int.MaxValue - n % 10) / 10 < newNumber)
                {
                    return 0;
                }

                newNumber = (newNumber * 10) + (n % 10);

                n /= 10;
            }
            return newNumber;
        }
    }
}