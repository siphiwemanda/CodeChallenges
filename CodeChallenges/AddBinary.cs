using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CodeChallenges
{
    public class AddBinary
    {
        public string Add(string bianryA, string binaryB)
        {
            var addBinary = ParseBinary(bianryA) + ParseBinary(binaryB);
            var changeBackToBinary = returnBinary(addBinary);
            return changeBackToBinary;
        }

        private string returnBinary(int addBinary)
        {
            var x = addBinary % 2;
            var y = addBinary / 2 % 2;

            return "";


        }
        
        private int ParseBinary(string binary)
        {
            var parsedBinary = 0;
            foreach (var digit in binary)
            {
                parsedBinary <<= 1;
                var value = (int) char.GetNumericValue(digit);
                parsedBinary += value;
            }

            return parsedBinary;
        }
    }
}