using System;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Třída obsahuje metody pro vyřešení kvadratické rovnice.
        /// </summary>
        public class ExtraMath
        {
            /// <summary>
            /// Instance pro pseudonáhodné generování čísel.
            /// </summary>
            private static Random numberGenerator = new Random();

            /// <summary>
            /// Generuje pseudonáhodné hodnoty ze zadaného intervalu.
            /// </summary>
            /// <param name="min">Minimální hodnota intervalu ze kterého se budou generovat hodnoty.</param>
            /// <param name="max">Maximální hodnota invervalu ze kterého se budou generovat hodnoty.</param>
            /// <returns></returns>
            public static double NumberGeneratroDouble(double min, double max)
            {
                return numberGenerator.NextDouble() * (max - min) + min;
            }

            /// <summary>
            /// Vyřeší kvadratickou rovnici a vrátí jeho řešení.
            /// </summary>
            /// <param name="a">Kvadratický člen</param>
            /// <param name="b">Lineární člen</param>
            /// <param name="c">Absolutní člen</param>
            /// <param name="x1">První kořen</param>
            /// <param name="x2">Druhý kořen</param>
            /// <returns>Vrací true pokud se podařilo najít řešení.</returns>
            public static bool SolveEuadraticEquation(double a, double b, double c, out double x1, out double x2)
            {
                double determinant = calculateDiscriminator(a, b, c);

                if (determinant < 0)
                {
                    x1 = x2 = 0;
                    return false;
                }

                x1 = (b + Math.Sqrt(determinant)) / (2 * a);
                x2 = (b - Math.Sqrt(determinant)) / (2 * a);

                return true;
            }

            /// <summary>
            /// Výpočet diskriminantu.
            /// </summary>
            /// <param name="a">Kvadratický člen</param>
            /// <param name="b">Lineární člen</param>
            /// <param name="c">Absolutní člen</param>
            /// <returns>Hodnotu diskriminantu</returns>
            private static double calculateDiscriminator(double a, double b, double c)
            {
                return Math.Pow(b, 2) - 4 * a * b;
            }
        }
    }
}