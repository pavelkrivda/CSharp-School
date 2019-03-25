using System;
using System.Windows.Forms;

namespace Exercise_Typing_with_all_ten_fingers
{
    public partial class MainWindow : Form
    {
        private readonly Random random;
        private readonly Stats stats;
        private Files files;

        private const int DEFAULT_DIFFICULT = 800;

        public MainWindow()
        {
            InitializeComponent();

            gameTimer.Interval = DEFAULT_DIFFICULT;

            random = new Random();
            stats = new Stats();
            files = new Files("words.txt");
            files.ReadAllRows();

            stats.UpdatedStats += updateCorrectLabel;
            stats.UpdatedStats += updateMissedLabel;
            stats.UpdatedStats += updateAccuracyLabel;
        }

        private void tickTimer(object sender, EventArgs e)
        {
            if (gameListBox.Items.Count == 6)
            {
                gameTimer.Stop();
                menuStrip1.Enabled = true;

                DialogResult result;
                result = MessageBox.Show(this, "Game over!\nYou want to play again?",
                    "Game over",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                startNewGame();
            }

            int randomNumber;
            if (Settings.EnteredTypeSelected == EnteredType.CHARACTERS)
            {
                randomNumber = random.Next(65, 91);
                gameListBox.Items.Add((Keys) randomNumber);
            }
            else
            {
                randomNumber = random.Next(files.CountRows);
                gameListBox.Items.Add(files.GetWordByIndex(randomNumber));
            }
        }

        private void gameListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameListBox.Items.Contains(e.KeyCode))
            {
                removeEntered(e);
                updateInformation();
            }
        }

        private void updateInformation()
        {
            updateTimerInterval();
            calculateDifficult();
            stats.Update(true);
        }

        private void removeEntered(KeyEventArgs e)
        {
            gameListBox.Items.Remove(e.KeyCode);
            gameListBox.Refresh();
        }

        private void calculateDifficult()
        {
            difficultProgressBar.Value = DEFAULT_DIFFICULT - gameTimer.Interval;
        }

        private void updateTimerInterval()
        {
            if (gameTimer.Interval > 400)
            {
                gameTimer.Interval -= 60;
            }
            else if (gameTimer.Interval > 250)
            {
                gameTimer.Interval -= 15;
            }
            else
            {
                gameTimer.Interval -= 8;
            }
        }

        private void updateCorrectLabel(object sender, EventArgs e)
        {
            correctLabel.Text = "Correct: " + stats.Correct.ToString();
        }

        private void updateMissedLabel(object sender, EventArgs e)
        {
            missedLabel.Text = "Missed: " + stats.Missed.ToString();
        }

        private void updateAccuracyLabel(object sender, EventArgs e)
        {
            accurancyLabel.Text = "Accuracy: " + stats.Accuracy.ToString() + '%';
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        private void startNewGame()
        {
            menuStrip1.Enabled = false;
            gameListBox.Items.Clear();
            gameTimer.Interval = DEFAULT_DIFFICULT;
            gameTimer.Start();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            this.Enabled = false;
            options.Closing += (o, args) => this.Enabled = true;
            options.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            this.Enabled = false;
            about.Closing += (o, args) => this.Enabled = true;
            about.Show();
        }
    }
}