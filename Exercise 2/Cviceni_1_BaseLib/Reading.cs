using System;

namespace Fei
{
    namespace BaseLib
    {
        public class Reading
        {
            /// <summary>
            /// Vypíše zadanou zprávu a přidá na konec dvojtečku a mezeru.
            /// </summary>
            /// <param name="zprava">Zpráva která se vypíše na monitor.</param>
            private static void writeMessage(string zprava)
            {
                Console.Write($"{zprava}: ");
            }

            /// <summary>
            /// Vypíše zadaný text. Načte a vrátí celočíselnou hodnotu zadanou z klávesnice.
            /// </summary>
            /// <param name="zprava">Zpráva která se vypíše na monitor.</param>
            /// <returns></returns>
            /// <exception cref="ArgumentException">Vyjímka v případě, že se nepodařilo načíst celočíselnou hodnotu!</exception>
            public static int ReadInt(string zprava)
            {
                writeMessage(zprava);
                
                if (int.TryParse(Console.ReadLine(), out var temp))
                {
                    return temp;
                }

                throw new ArgumentException("Nepodařilo se převést zadanou vstupní hodnotu!");
            }

            /// <summary>
            /// Vypíše zadaný text. Načte a vrátí reálné číslo zadané z klávesnice.
            /// </summary>
            /// <param name="zprava">Zpráva která se vypíše na monitor.</param>
            /// <returns>Načtené reálné číslo z klávesnice.</returns>
            /// <exception cref="ArgumentException">Vyjímka v případě, že se nepodařilo načíst reálné číslo!</exception>
            public static double ReadDouble(string zprava)
            {
                writeMessage(zprava);

                if (double.TryParse(Console.ReadLine(), out var temp))
                {
                    return temp;
                }

                throw new ArgumentException("Nepodařilo se převést zadanou vstupní hodnotu!");
            }

            /// <summary>
            /// Vypíše zadaný text. Načte a vrátí jeden znak načtený z klávesnice.
            /// </summary>
            /// <param name="zprava">Zpráva která se vypíše na monitor.</param>
            /// <returns>Načtený znak z klávesnice.</returns>
            /// <exception cref="ArgumentException">Vyjímka v případě, že se nepodařilo načíst znak!</exception>
            public static char ReadChar(string zprava)
            {
                writeMessage(zprava);

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key != ConsoleKey.Enter)
                {
                    return keyInfo.KeyChar;
                }

                throw new ArgumentException("Nepodařilo se načíst znak!");
            }

            /// <summary>
            /// Vypíše zadaný text. Načte a vrátí řetěžec zadaný z klávesnice.
            /// </summary>
            /// <param name="zprava">Zpráva která se vypíše na monitor.</param>
            /// <returns>Načtený řetězec z klávesnice.</returns>
            /// <exception cref="ArgumentException">Vyjímka v případě, že se nepodařilo načíst řetězec!</exception>
            public static string ReadString(string zprava)
            {
                writeMessage(zprava);
                
                string input = Console.ReadLine();
                if (input.Length != 0)
                {
                    return input;
                }

                throw new ArgumentException("Nebyl zadán vstupní text!");
            }
        }
    }
}