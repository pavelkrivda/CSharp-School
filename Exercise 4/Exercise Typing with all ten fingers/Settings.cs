using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Typing_with_all_ten_fingers
{
    public enum EnteredPosition
    {
        FIRST,
        LAST,
        ANY
    }

    public enum EnteredType
    {
        CHARACTERS,
        WORDS
    }

    class Settings
    {
        public static EnteredPosition EnteredPositionSelected { get; set; } = EnteredPosition.ANY;
        public static EnteredType EnteredTypeSelected { get; set; } = EnteredType.CHARACTERS;
    }
}
