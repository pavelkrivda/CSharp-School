using System;
using System.Windows.Forms;

namespace Exercise_Liga_Mistru
{
    public delegate void PlayerHandler(Player player);

    public partial class MainWindow : Form
    {
        private readonly Players players;

        public MainWindow()
        {
            InitializeComponent();
            playerDataGridView.MultiSelect = false;

            players = new Players(
                new PocetZmenenEventHandler(changeCountPlayers));
        }

        private void addPlayer(Player player)
        {
            playerDataGridView.Rows.Add(player.Name, player.Club, player.GolsCount);
            players.AddPlayer(player);
        }

        private void editPlayer(Player player)
        {
            playerDataGridView.Rows.Clear();

            for (int i = 0; i < players.CountPlayer; i++)
            {
                playerDataGridView.Rows.Add(player.Name, player.Club, player.GolsCount);
            }
        }

        private void changeCountPlayers(object sender, OriginalCountPlayersEventArgs eventArgs)
        {
            eventListBox.Items.Add(
                $"Původni počet hráčů je: {eventArgs.OriginalCountPlayers}, " +
                $"aktuální stav je: {playerDataGridView.Rows.Count - 1}");
        }

        private void addPlayerButton_Click_1(object sender, EventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow(new PlayerHandler(addPlayer), null);
            playerWindow.ShowDialog();
        }

        private void removePlayerButton_Click_1(object sender, EventArgs e)
        {
            if (playerDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Není vybrán hráč který mý být odstraněn!", "Chyba operace", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                int index = playerDataGridView.SelectedRows[0].Index;
                playerDataGridView.Rows.RemoveAt(index);
                players.RemovePlayer(index);
            }

            removePlayerButton.Enabled = false;
            editPlayerButton.Enabled = false;

            if (playerDataGridView.Rows.Count == 0)
            {
                findBestClubButton.Enabled = false;
            }
        }

        private void editPlayerButton_Click_1(object sender, EventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow(new PlayerHandler(editPlayer), players[playerDataGridView.SelectedRows[0].Index]);
            playerWindow.ShowDialog();

            removePlayerButton.Enabled = false;
            editPlayerButton.Enabled = false;
        }

        private void findBestClubButton_Click_1(object sender, EventArgs e)
        {
            players.NajdiNejlepsiKluby(out FootballClub[] clubs, out int countGols);
            TopClubsWindow topClubs = new TopClubsWindow(clubs, countGols);
            topClubs.ShowDialog();
        }

        private void registerHandlerButton_Click_1(object sender, EventArgs e)
        {
            players.Register(true);

            registerHandlerButton.Enabled = false;
            unregisterHandlerButton.Enabled = true;
        }

        private void unregisterHandlerButton_Click_1(object sender, EventArgs e)
        {
            players.Register(false);

            unregisterHandlerButton.Enabled = false;
            registerHandlerButton.Enabled = true;
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void playerDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            findBestClubButton.Enabled = true;
        }

        private void playerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            removePlayerButton.Enabled = true;
            editPlayerButton.Enabled = true;
        }
    }
}
