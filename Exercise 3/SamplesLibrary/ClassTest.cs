using System;
using Microsoft.Win32.SafeHandles;

namespace Exercise_3.SamplesLibrary
{
    internal class MyInteger
    {
        public uint Value
        {
            get { return Value;}
            set { Value = value; }
        }

        private uint value2;
        public int Value2 {
            get { return (int)value2; }
            set
            {
                if (value > 1000000)
                {
                    throw new ArgumentOutOfRangeException("value cannot be higher than 1000000");
                }

                Minus = value < 0;
                value2 = (uint)value;
            }
        }

        public bool Minus { get; private set; }

        public bool Signed { get; private set; }


        public uint Value3 { get; set; } = 15;

        private static int GetMaxInt()
        {
            return int.MaxValue;
        }

        public int Value4 => GetMaxInt() * 3;
        public MyInteger()
        {
        }

        public MyInteger(uint value, bool signed)
        {
            Value = value;
            Signed = signed;
        }

        public static implicit operator MyInteger(uint v)
        {
            return new MyInteger() {Value = (uint) Math.Abs(v), Signed = v < 0};
        }
    }

    public class ClassTest
    {
        public static void DoIt()
        {
            MyInteger myInteger = new MyInteger() {Value = 53};
            MyInteger myInteger1 = new MyInteger(33, true);

            MyInteger myInteger2 = 125;
        }
    }
}