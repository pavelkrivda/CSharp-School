using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Exercise_Liga_Mistru
{
    public partial class MainWindow : Form
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow();
            playerWindow.ShowDialog();
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void editPlayerButton_Click(object sender, EventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow();
            playerWindow.ShowDialog();
        }

        private void findBestClubButton_Click(object sender, EventArgs e)
        {
            TopClubsWindow topClubs = new TopClubsWindow();
            topClubs.ShowDialog();
        }

        private void registerHandlerButton_Click(object sender, EventArgs e)
        {

        }

        private void unregisterHandlerButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
