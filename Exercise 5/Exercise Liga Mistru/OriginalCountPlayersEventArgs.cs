using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Liga_Mistru
{
    public class OriginalCountPlayersEventArgs
    {
        public int OriginalCountPlayers { get; set; }

        public OriginalCountPlayersEventArgs(int originalCountPlayers)
        {
            OriginalCountPlayers = originalCountPlayers;
        }
    }
}
