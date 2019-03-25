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
            playersListView.MultiSelect = false;
            playersListView.FullRowSelect = true;

            players = new Players(
                new PocetZmenenEventHandler(changeCountPlayers));
        }

        private void addPlayer(Player player)
        {
            ListViewItem item = new ListViewItem();
            item.Text = player.Name;
            item.SubItems.Add(player.Club.ToString());
            item.SubItems.Add(player.GolsCount.ToString());
            playersListView.Items.Add(item);
            players.AddPlayer(player);

            if (!findBestClubButton.Enabled)
                findBestClubButton.Enabled = true;
        }

        private void editPlayer(Player player)
        {
            playersListView.Items.Clear();

            for (int i = 0; i < players.CountPlayer; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = players[i].Name;
                item.SubItems.Add(player.Club.ToString());
                item.SubItems.Add(players[i].GolsCount.ToString());
                playersListView.Items.Add(item);
            }
        }

        private void changeCountPlayers(object sender, OriginalCountPlayersEventArgs eventArgs)
        {
            eventListBox.Items.Add(
                $"Původni počet hráčů je: {eventArgs.OriginalCountPlayers}, " +
                $"aktuální stav je: {playersListView.Items.Count}");
        }

        private void addPlayerButton_Click_1(object sender, EventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow(new PlayerHandler(addPlayer), null);
            playerWindow.ShowDialog();
        }

        private void removePlayerButton_Click_1(object sender, EventArgs e)
        {
            if (playersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Není vybrán hráč který mý být odstraněn!", "Chyba operace", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                int index = playersListView.SelectedItems[0].Index;
                playersListView.Items.RemoveAt(index);
                players.RemovePlayer(index);
            }

            removePlayerButton.Enabled = false;
            editPlayerButton.Enabled = false;

            if (playersListView.Items.Count == 0)
            {
                findBestClubButton.Enabled = false;
            }
        }

        private void editPlayerButton_Click_1(object sender, EventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow(new PlayerHandler(editPlayer), players[playersListView.SelectedItems[0].Index]);
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

        private void playersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            removePlayerButton.Enabled = true;
            editPlayerButton.Enabled = true;
        }
    }
}
