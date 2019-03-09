using System;

namespace Fei
{
    namespace BaseLib
    {
        public class ExtraMath
        {
            private static Random numberGenerator = new Random();

            public static double NumberGeneratroDouble(double min, double max)
            {
                return numberGenerator.NextDouble() * (max - min) + min;
            }

            public static bool SolveEuadraticEquation(double a, double b, double c, out double x1, out double x2)
            {
                double determinant = calculateDeterminant(a, b, c);

                if (determinant < 0)
                {
                    x1 = x2 = 0;                    
                    return false;
                }

                x1 = (b + Math.Sqrt(determinant)) / (2 * a);
                x2 = (b - Math.Sqrt(determinant)) / (2 * a);

                return true;
            }

            private static double calculateDeterminant(double a, double b, double c)
            {
                return Math.Pow(b, 2) - 4 * a * b;
            }
        }
    }
}