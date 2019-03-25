using System;
using System.Windows.Forms;

namespace Exercise_Liga_Mistru
{
    public partial class TopClubsWindow : Form
    {
        public TopClubsWindow(FootballClub[] clubs, int countGols)
        {
            InitializeComponent();
            
            countGolsTextBox.Text = countGols.ToString();

            foreach (var club in clubs)
                topClubsListBox.Items.Add(club);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
