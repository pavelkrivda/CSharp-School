using System;

namespace Utils
{
    /// <summary>
    /// Random number generator
    /// Random number generator with [min, max] range. 
    /// Random number generator with [-10, 10] range.
    /// </summary>
    public static class RandomNumberGenerator
    {
        private static readonly Random random = new Random();
        private const int MIN_VALUE = -10;
        private const int MAX_VALUE = 10;

        /// <summary>
        /// Print class name without namespace.
        /// </summary>
        public static void GetClassName()
        {
            Console.WriteLine(nameof(RandomNumberGenerator));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Random number</returns>
        public static int Next()
        {
            return random.Next();
        }

        public static int Next(int min, int max)
        {
            return min + random.Next() % (max + 1 - min);
        }

        public static int NextConst()
        {
            return random.Next(MIN_VALUE, MAX_VALUE);
        }
    }
}
