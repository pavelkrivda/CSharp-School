using System;
using Exercise_3.SamplesLibrary;
using Utils;

namespace Exercise_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Random number: {RandomNumberGenerator.Next()}");
            ConversionTest.DoIt();
            OverFlowUnderFlow.DoIt();
            
        }
    }
}