using System;
using System.Linq;
using System.Windows.Forms;

namespace Exercise_Liga_Mistru
{
    public partial class PlayerWindow : Form
    {
        private PlayerHandler playerHandler;
        private Player player;

        public PlayerWindow(PlayerHandler playerHandler, Player player)
        {
            InitializeComponent();
            this.playerHandler = playerHandler;
            this.player = player;

            playerClubComboBox.Items.AddRange(Clubs.getAllNameFootballClub());

            if (player == null)
                playerClubComboBox.SelectedIndex = 0;
            else
            {
                playerNameTextBox.Text = player.Name;
                playerClubComboBox.SelectedIndex =
                    Array.FindIndex(Enum.GetNames(typeof(FootballClub)), w => w.Equals(player.Club.ToString()));
                playerCountGolTextBox.Text = player.GolsCount.ToString();
            }
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            string error = string.Empty;

            if (playerNameTextBox.Text.Length == 0 || playerNameTextBox.Text[0] == ' ')
                error += "Nezadali jste platné jméno hráče!" + Environment.NewLine;

            if (playerCountGolTextBox.Text.Length == 0 || !int.TryParse(playerCountGolTextBox.Text, out _))
                error += "Nezadali jste platný počet gólů!";

            if (!error.Equals(string.Empty)) return;

            string playerName = playerNameTextBox.Text;
            FootballClub footballClub = ((FootballClub) playerClubComboBox.SelectedIndex);
            int.TryParse(playerCountGolTextBox.Text, out var countGols);

            if (player == null)
            {
                Player tempPlayer = new Player(playerName, footballClub, countGols);
                playerHandler(tempPlayer);
            }
            else
            {
                player.Name = playerName;
                player.Club = footballClub;
                player.GolsCount = countGols;
                playerHandler(player);
            }
           
            Close();
        }

        private void stornoPlayerButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
