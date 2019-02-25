using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkWithStaticClass();
            //WorkWithDataType();
            //WorkWithNullableTypes();

            int[,] array01 = new int[2,3];
            int[][] array02 = new int[2][];

            array02[0] = new int[4];
            // 0 1 2 3 4 5 6 7 8 9
            // x 
            //   A A A A

            array02[1] = new int[2];
            // 0 1 2 3 4 5 6 7 8 9
            // x 
            //     A A A A
            //             B B
        }

        private static void WorkWithDataType()
        {
            int x = 3;
            int y = x;
            y += 2;
            x++;
            Console.WriteLine($"x: {x}; y: {y}");

            ComplexNumber number1 = new ComplexNumber(){First = 1, Second = 2};
            //ComplexNumber number2 = number1;}}
            ComplexNumber number2 = new ComplexNumber(number1);

            number2.First += 2;
            number1.Second++;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }

        private static void WorkWithStaticClass()
        {
            RandomNumberGenerator.GetClassName();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(RandomNumberGenerator.Next());
            }

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(RandomNumberGenerator.Next(-10, 10));
            }
        }

        private static bool tryParse(string text, out int result)
        {
            return int.TryParse(text, out result);
        }

        private static int getMagicWand(string text)
        {
            if (text.Length == 0)
                return -1;
            return text.Length;
        }

        private static void WorkWithNullableTypes()
        {
            int number1 = 3;
            int? number2 = null;
            ComplexNumber number3 = null;

            if (number2.HasValue)
            {
                int number4 = number2.Value;
            }
            number3?.Third.GetType();

            ComplexNumber number5 = new ComplexNumber(1,2,null);
            number5?.Third?.GetType();

        }
    }
}
