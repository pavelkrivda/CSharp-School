using System;
using System.Linq;

namespace Exercise_Liga_Mistru
{
    public delegate void PocetZmenenEventHandler(object sender, OriginalCountPlayersEventArgs eventArgs);
    public delegate void RegisterHandler(bool register);

    class Players
    {
        private const int MAX_PLAYER_COUNT = 20;
        private Player[] players = new Player[MAX_PLAYER_COUNT];
        public int CountPlayer { get; private set; }

        private PocetZmenenEventHandler countPlayersHandler;
        private event PocetZmenenEventHandler OnChangeCountPlayers;

        public RegisterHandler Register { get; }

        public Players(PocetZmenenEventHandler countPlayersHandler)
        {
            this.countPlayersHandler = countPlayersHandler;
            Register = new RegisterHandler(registerHandler);
        }

        public void RemovePlayer(int index)
        {
            if (index < 0 || index > CountPlayer)
            {
                throw new ArgumentException("Neplatný index!");
            }

            players[index] = null;
            reorganizePlayers();

            OnChangeCountPlayers?.Invoke(this, new OriginalCountPlayersEventArgs(CountPlayer + 1));
        }

        private void reorganizePlayers()
        {
            for (int i = 0; i < players.Length - 1; i++)
            {
                if (players[i] == null && players[i + 1] != null)
                {
                    players[i] = players[i + 1];
                    players[i + 1] = null;
                }
                else if (players[i] == null && players[i + 1] == null)
                {
                    break;
                }
            }

            --CountPlayer;
        }

        public void AddPlayer(Player player)
        {
            if (CountPlayer > MAX_PLAYER_COUNT)
            {
                throw new ArgumentException("Nelze vložit dalšího hráče!");
            }


            players[CountPlayer++] = player;

            OnChangeCountPlayers?.Invoke(this, new OriginalCountPlayersEventArgs(CountPlayer - 1));
        }

        public Player this[int index]
        {
            get { return players[index]; }
        }

        public void NajdiNejlepsiKluby(out FootballClub[] clubs, out int golCount)
        {
            var clubsGols = new (FootballClub, int)[Clubs.getCountClubs()];
            Player[] tempPlayers = new Player[CountPlayer];
            Array.Copy(players, tempPlayers, CountPlayer);

            for (int i = 0; i < Clubs.getCountClubs(); i++)
                clubsGols[i] = (((FootballClub)i), (from player in tempPlayers
                                                    where player.Club == ((FootballClub)i)
                                                    select player.GolsCount).Sum());


            int maxGolCount = clubsGols.Max(tuple2 => tuple2.Item2);
            golCount = maxGolCount;

            clubs = clubsGols.Where(tuple => tuple.Item2 >= maxGolCount)
                .Select(tuple => (tuple.Item1)).ToArray();
        }

        private void registerHandler(bool register)
        {
            if (register)
                OnChangeCountPlayers = countPlayersHandler;
            else
                OnChangeCountPlayers -= countPlayersHandler;
        }
    }
}