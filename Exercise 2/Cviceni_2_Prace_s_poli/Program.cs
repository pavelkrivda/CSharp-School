using System;
using System.Linq;
using Fei.BaseLib;

namespace Cviceni_2_Prace_s_poli
{
    internal class Program
    {
        private const int ARRAY_SIZE = 5;
        private static int[] intArray = new int[ARRAY_SIZE];
        private static int count = 0;

        public static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine();
                printMenu();
                choice = inputValues("Zadej číslo operace");
                Console.WriteLine();

                executeChoice(choice);
            } while ((choice >= 1 && choice <= 8) || choice != 9);

            Console.WriteLine("Konec programu.");
        }

        private static void executeChoice(int choice)
        {
            int number;
            int index;
            
            try
            {
                switch (choice)
                {
                    case 1:
                        if (count == ARRAY_SIZE)
                        {
                            throw new ArgumentOutOfRangeException("Pole je plné!");
                        }

                        intArray[count++] = inputValues("Zadej číslo");
                        break;

                    case 2:
                        printArray();
                        break;

                    case 3:
                        shortArrayAscending();
                        break;

                    case 4:
                        shortArrayDescending();
                        break;

                    case 5:
                        number = findMinElemnt();
                        Console.WriteLine($"Nejmenší číslo v poli je {number}.");
                        break;

                    case 6:
                        number = findMaxElement();
                        Console.WriteLine($"Největší číslo v poli je {number}.");
                        break;

                    case 7:
                        number = inputValues("Zadej číslo");
                        index = getFirstIndexElement(number);
                        Console.WriteLine($"První výskyt čísla: {number} v poli je na indexu: {index}.");
                        break;

                    case 8:
                        number = inputValues("Zadej číslo");
                        index = getLastIndexElement(number);
                        Console.WriteLine($"Poslední výskyt čísla: {number} v poli je na indexu: {index}.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void printMenu()
        {
            Console.WriteLine("1. Zadaní prvků pole z klávesnice\n" +
                              "2. Výpis pole na obrazovku\n" +
                              "3. Utřídění pole vzestupně\n" +
                              "4. Utřídění pole sestupně\n" +
                              "5. Hledání minimálního prvku\n" +
                              "6. Hledání minimálního prvku\n" +
                              "7. Hledání prvního výskytu zadaného čísla\n" +
                              "8. Hledání posledního výskytu zadaného čísla\n" +
                              "9. Konec programu");
        }

        private static int inputValues(string message)
        {
            int? number = null;
            do
            {
                try
                {
                    number = Reading.ReadInt(message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (number == null);

            return number.Value;
        }

        private static void printArray()
        {
            Console.WriteLine("Výpis položek v poli: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"Na indexu {i} je hodnota: {intArray[i]}");
            }
        }

        private static void shortArrayAscending()
        {
            Array.Sort(intArray);
        }

        private static void shortArrayDescending()
        {
            Array.Sort(intArray);
            Array.Reverse(intArray);
        }

        private static int findMinElemnt()
        {
            return intArray.Min();
        }

        private static int findMaxElement()
        {
            return intArray.Max();
        }

        private static int getFirstIndexElement(int number)
        {
            return Array.FindIndex(intArray, element => element == number);
        }

        private static int getLastIndexElement(int number)
        {
            return Array.FindLastIndex(intArray, element => element == number);
        }
    }
}