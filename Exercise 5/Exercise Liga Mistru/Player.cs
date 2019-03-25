using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Liga_Mistru
{
    public class Player
    {
        public string Name { get; set; }
        public FootballClub Club { get; set; }
        public int GolsCount { get; set; }

        public Player(string name, FootballClub club, int golsCount)
        {
            Name = name;
            Club = club;
            GolsCount = golsCount;
        }

        public override string ToString()
        {
            return $"{Name} {Club} {GolsCount}";
        }
    }
}
