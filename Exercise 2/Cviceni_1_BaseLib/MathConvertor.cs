using System;
using System.Collections.Generic;
using System.Text;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Třída pro převod mezi číselnými soustavy. Umožňuje převod Dekadických čísel do binární soustavy a naopak.
        /// Dále umožnuje převod Dekadických čísel do Římských a naopak.
        /// </summary>
        public class MathConvertor
        {
            /// <summary>
            /// Slovník pro uchování římských písmen a jejich reprezentace v desítkové soustavě.
            /// </summary>
            public static readonly Dictionary<char, int> RomanNumberDictionary;

            /// <summary>
            /// Slovník pro uchování hodnot v desítkové soustavě a jejich reprezentace v římských písmenech.
            /// </summary>
            public static readonly Dictionary<int, string> NumberRomanDictionary;

            /// <summary>
            /// Převod čísla z desítkového čísla do binární soustavy.
            /// </summary>
            /// <param name="decimalNumber">Číslo v desítkové soustavě které bude převedeno do binární soustavy.</param>
            /// <returns>Číslo v binární soustavě.</returns>
            public static string DecToBin(int decimalNumber)
            {
                return Convert.ToString(decimalNumber, 2);
            }

            /// <summary>
            /// Převod binárních čísel na číslo v desítkové soustavě.
            /// </summary>
            /// <param name="binaryNumber">Binární číslo které se bude převádět do desítkové soustavy.</param>
            /// <returns>Číslo v desítkové soustavě.</returns>
            public static int BinToDec(string binaryNumber)
            {
                return Convert.ToInt32(binaryNumber, 2);
            }

            /// <summary>
            /// Pomocné struktury pro převod z destíkové soustavy do římkých čísel.
            /// </summary>
            static MathConvertor()
            {
                RomanNumberDictionary = new Dictionary<char, int>
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000},
                };

                NumberRomanDictionary = new Dictionary<int, string>
                {
                    {1000, "M"},
                    {900, "CM"},
                    {500, "D"},
                    {400, "CD"},
                    {100, "C"},
                    {50, "L"},
                    {40, "XL"},
                    {10, "X"},
                    {9, "IX"},
                    {5, "V"},
                    {4, "IV"},
                    {1, "I"},
                };
            }

            /// <summary>
            /// Převod čísla zapsaný římskými čísli na číslo v desítkové soustavě.
            /// </summary>
            /// <param name="romanNumber">Číslo zapsané římsky které se převede na číslo v desítkové soustavě.</param>
            /// <returns>Číslo v desítkové soustavě.</returns>
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

            /// <summary>
            /// Převede číslo zadané v desítkové soustavě do římských čísel.
            /// </summary>
            /// <param name="decimalNumber">Hodnota zadaná v desítkové soustavě které se bude převádět.</param>
            /// <returns>Římsky zapsaná hodnota zadaného čísla v desítkové soustavě.</returns>
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