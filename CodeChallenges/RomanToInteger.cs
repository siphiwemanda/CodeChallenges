using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenges
{
    public class RomanToInteger
    {

        public int RomanToInt(string numbers)
        {

            var romanNumerals = numbers.ToCharArray();
            var numericalNumbers = new List<int>();
            
            var dictionary = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };
            var variationDictionary = new Dictionary<string, int>()
            {
                {"IV", 2},
                {"IX", 2},
                {"XL", 20},
                {"XC", 20},
                {"CD", 200},
                {"CM", 200}
            };

            foreach (var numeral in romanNumerals)
            {
                foreach (var (key, value) in dictionary)
                {
                    if (numeral.Equals(key))
                    {
                        numericalNumbers.Add(value);
                    }
                }
            }
            var sum = numericalNumbers.Sum();
            var x = 0; 
            
            foreach (var (key,value) in variationDictionary)
            {
                if (numbers.Contains(key))
                {
                    x += value;
                }
            }
            return sum - x;
        }
    }
}
