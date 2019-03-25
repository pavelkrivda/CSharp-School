using System;
using System.Windows.Forms;

namespace Exercise_Liga_Mistru
{
    public delegate void AddPlayerHandler(Player player);

    public partial class MainWindow : Form
    {
        private readonly Players players;
        private bool registerEvent = true;

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
        }

        private void changeCountPlayers(object sender, OriginalCountPlayersEventArgs eventArgs)
        {
            if (registerEvent)
            {
                eventListBox.Items.Add(
                    $"Původni počet hráčů je: {eventArgs.OriginalCountPlayers}, " +
                    $"aktuální stav je: {playersListView.Items.Count}");
            }
        }

        private void addPlayerButton_Click_1(object sender, EventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow(new AddPlayerHandler(addPlayer));
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
        }

        private void editPlayerButton_Click_1(object sender, EventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow(new AddPlayerHandler(addPlayer));
            playerWindow.ShowDialog();
        }

        private void findBestClubButton_Click_1(object sender, EventArgs e)
        {
            players.NajdiNejlepsiKluby(out FootballClub[] clubs, out int countGols);
            TopClubsWindow topClubs = new TopClubsWindow(clubs, countGols);
            topClubs.ShowDialog();
        }

        private void registerHandlerButton_Click_1(object sender, EventArgs e)
        {
            registerEvent = true;
        }

        private void unregisterHandlerButton_Click_1(object sender, EventArgs e)
        {
            registerEvent = false;
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
