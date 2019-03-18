using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Liga_Mistru
{
    class Players
    {
        public delegate 

        private const int MAX_PLAYER_COUNT = 20;
        private Player[] players = new Player[MAX_PLAYER_COUNT];
        public int CountPlayer { get; set; }

        public void RemovePlayer(int index)
        {
            if (index < 0 || index > CountPlayer)
            {
                throw  new ArgumentException("Neplatný index!");
            }

            players[index] = null;
            reorganizePlayers();
        }

        public int Pocet { get; }

        private void reorganizePlayers()
        {
            //TODO srovnej pole pokud nebyl odebran hrac z konce pole 


            --CountPlayer;
        }

        public void AddPlayer(Player player)
        {
            if (CountPlayer > MAX_PLAYER_COUNT)
            {
                throw new ArgumentException("Nelze vložit dalšího hráče!");
            }

            players[CountPlayer++] = player;
        }

        public Player this[int index]
        {
            get { return players[index]; }
            set { players[index] = value; }
        }

        public (FotbalovyKlub[], int[]) NajdiNejlepsiKluby(FotbalovyKlub[] clubs, int[] golCount)
        {

            return (null, null);
        }
    }
}
