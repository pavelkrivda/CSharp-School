using System;
using System.Threading;

namespace exercis_4_hadani_cisla
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int hadane;
            int pocetPokusu;
            char volba;
            int tip;

            do
            {
                hadane = random.Next(0, 100);
                pocetPokusu = 0;

                Console.WriteLine(hadane);
                
                while (pocetPokusu < 10)
                 {
                    Console.Write("Zadej svůj tip: ");
                    
                    if (!int.TryParse(Console.ReadLine(), out tip))
                    {
                        Console.WriteLine("Nesprávný znak");
                        continue;
                    }

                    if (tip == hadane)
                    {
                        Console.WriteLine("Uhádl jsi");
                        break;
                    }

                    Console.WriteLine($"Neuhádl jsi náhodné číslo je {(tip > hadane ? "menší" : "větší")}");
                    pocetPokusu++;
                }

                Console.Write("Pro ukončení zadejte (k) chceteli hrát znovu zmáčknětě libovolnou klávesu: ");
                volba = (char)Console.Read();
            } while (volba != 'k');
        }
    }
}