using System;
using System.Windows.Forms;

namespace Exercise_Typing_with_all_ten_fingers
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();

            if (Settings.EnteredPositionSelected == EnteredPosition.FIRST)
            {
                enteredPositionFirstRadioButton.Checked = true;
            }
            else if(Settings.EnteredPositionSelected == EnteredPosition.LAST)
            {
                enteredPositionLastRadioButton.Checked = true;
            }
            else
            {
                enteredPositionAnyRadioButton.Checked = true;
            }

            if (Settings.EnteredTypeSelected == EnteredType.CHARACTERS)
            {
                enteredTypeCharacterRadioButton.Checked = true;
            }
            else
            {
                enteredTypeWordsRadioButton.Checked = true;
            }

        }

        private void radioButtonEnteredPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (enteredPositionFirstRadioButton.Checked)
            {
                Settings.EnteredPositionSelected = EnteredPosition.FIRST;
            }else if (enteredPositionLastRadioButton.Checked)
            {
                Settings.EnteredPositionSelected = EnteredPosition.LAST;
            }
            else
            {
                Settings.EnteredPositionSelected = EnteredPosition.ANY;
            }
        }

        private void radioButtonEnteredType_CheckedChanged(object sender, EventArgs e)
        {
            if (enteredTypeCharacterRadioButton.Checked)
            {
                Settings.EnteredTypeSelected = EnteredType.CHARACTERS;
                groupBox1.Enabled = true;
            }
            else
            {
                Settings.EnteredTypeSelected = EnteredType.WORDS;
                groupBox1.Enabled = false;
                Settings.EnteredPositionSelected = EnteredPosition.ANY;
            }
        }
    }
}
