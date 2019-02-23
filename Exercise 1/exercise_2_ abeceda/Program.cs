using System;

namespace exercis_1__abeceda
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      
      cyklusFor();

      cyklusWhile();

      cyklusDoWhile();
    }

    private static void cyklusFor()
    {
      Console.WriteLine("Výpis pomocí cyklu for:");
      for (int i = 97; i <= 122; i++)
      {
        Console.WriteLine((char) i);
      }
    }

    private static void cyklusWhile()
    {
      Console.WriteLine("Výpis pomocí cyklu while:");
      int pocitadlo = 97;
      while (pocitadlo <= 122)
      {
        Console.WriteLine((char) pocitadlo++);
      }
    }

    private static void cyklusDoWhile()
    {
      Console.WriteLine("Výpis pomocí cyklu do while:");
      int pocitadlo = 97;
      do
      {
        Console.WriteLine((char) pocitadlo);
      } while (pocitadlo++ < 122);
    }
  }
}