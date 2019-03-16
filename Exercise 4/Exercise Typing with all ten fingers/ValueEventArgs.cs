using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Typing_with_all_ten_fingers
{
    class ValueEventArgs
    {
        public string Message { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return $"{Message}: {Value}";
        }
    }
}
