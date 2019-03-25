using System;
using System.Windows.Forms;

namespace Exercise_Liga_Mistru
{
    public partial class PlayerWindow : Form
    {
        private AddPlayerHandler playerHandler;

        public PlayerWindow(AddPlayerHandler playerHandler)
        {
            InitializeComponent();
            this.playerHandler = playerHandler;
            playerClubComboBox.Items.AddRange(Clubs.getAllNameFootballClub());
            playerClubComboBox.SelectedIndex = 0;
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            string error = string.Empty;

            if (playerNameTextBox.Text.Length == 0 || playerNameTextBox.Text[0] == ' ')
                error += "Nezadali jste platné jméno hráče!" + Environment.NewLine;

            if (playerCountGolTextBox.Text.Length == 0 || !int.TryParse(playerCountGolTextBox.Text, out _))
                error += "Nezadali jste platný počet gólů!";

            if (error.Equals(string.Empty))
            {
                string playerName = playerNameTextBox.Text;
                FootballClub footballClub = ((FootballClub) playerClubComboBox.SelectedIndex);
                int.TryParse(playerCountGolTextBox.Text, out var countGols);

                Player tempPlayer = new Player(playerName, footballClub, countGols);
                playerHandler(tempPlayer);
                Close();
            }
        }

        private void stornoPlayerButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
