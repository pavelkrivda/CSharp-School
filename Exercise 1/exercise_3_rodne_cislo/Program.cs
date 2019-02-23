using System;
using System.Security.AccessControl;

namespace exercis_1_rodne_cislo
{
    internal class Program
    {
        private static string rodneCislo(string rodneCislo)
        {
            if (!int.TryParse(rodneCislo, out _) && rodneCislo.Length != 10)
            {
                throw new ArgumentException("Neplatné rodné číslo");
            }

            var temp = rodneCislo.Substring(6, 4);
            Console.WriteLine(temp);
            int.TryParse(temp, out var poradoveCislo);
            return (poradoveCislo % 2 == 0 ? "Žena" : "Muž");

        }

        private static string rodneCislo(ulong rodneCislo)
        {
            return Program.rodneCislo(rodneCislo.ToString());
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(rodneCislo("4405140145"));
            Console.WriteLine(rodneCislo(4405140145));
        }
    }
}