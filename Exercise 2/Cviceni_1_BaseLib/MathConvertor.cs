using System;
using System.Collections.Generic;
using System.Text;

namespace Fei
{
    namespace BaseLib
    {
        public class MathConvertor
        {
            public static readonly Dictionary<char, int> RomanNumberDictionary;
            public static readonly Dictionary<int, string> NumberRomanDictionary;
            
            public static string DecToBin(int decimalNumber)
            {
                return Convert.ToString(decimalNumber, 2);
            }

            public static int BinToDec(string binaryNumber)
            {
                return Convert.ToInt32(binaryNumber, 2);
            }


            static MathConvertor()
            {
                RomanNumberDictionary = new Dictionary<char, int>
                {
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 },
                };

                NumberRomanDictionary = new Dictionary<int, string>
                {
                    { 1000, "M" },
                    { 900, "CM" },
                    { 500, "D" },
                    { 400, "CD" },
                    { 100, "C" },
                    { 50, "L" },
                    { 40, "XL" },
                    { 10, "X" },
                    { 9, "IX" },
                    { 5, "V" },
                    { 4, "IV" },
                    { 1, "I" },
                };
            }

            public static int RomanToDec(string romanNumber)
            {
                int total = 0;

                int current, previous = 0;
                char currentRoman, previousRoman = '\0';

                for (int i = 0; i < romanNumber.Length; i++)
                {
                    currentRoman = romanNumber[i];

                    previous = previousRoman != '\0' ? RomanNumberDictionary[previousRoman] : '\0';
                    current = RomanNumberDictionary[currentRoman];

                    if (previous != 0 && current > previous)
                    {
                        total = total - (2 * previous) + current;
                    }
                    else
                    {
                        total += current;
                    }

                    previousRoman = currentRoman;
                }

                return total;
            }

            public static string DecToRoman(int decimalNumber)
            {
                var roman = new StringBuilder();

                foreach (var item in NumberRomanDictionary)
                {
                    while (decimalNumber >= item.Key)
                    {
                        roman.Append(item.Value);
                        decimalNumber -= item.Key;
                    }
                }

                return roman.ToString();
            }
        }
    }
}