using System;

namespace Exercise_3.SamplesLibrary
{
    public class OverFlowUnderFlow
    {
        public static void DoIt()
        {
            uint max = uint.MaxValue;
            uint min = uint.MinValue;

            Console.WriteLine($"max: {max}, min: {min}");

            checked
            {
                max++;
                min--;
            }

            unchecked
            {
                
            }
            
            Console.WriteLine($"max: {max}, min: {min}");
        }
    }
}