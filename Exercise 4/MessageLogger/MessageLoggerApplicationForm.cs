using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageLogger
{
    public partial class MessageLoggerApplicationForm : Form
    {
        EventHandler sendTextToLeftOutputEventHandler;
        EventHandler sendTextToRightOutputEventHandler;

        public MessageLoggerApplicationForm()
        {
            InitializeComponent();
            this.sendTextToLeftOutputEventHandler = new EventHandler(SendTextToLeftOutput);
            this.sendTextToRightOutputEventHandler = new EventHandler(SendTextToRightOutput);
        }

        private void RightOutputGroup_Enter(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
        }

        private void SendTextToLeftOutput(object sender, EventArgs e)
        {
            this.LeftOutputText.Text += InputText.Text + "\r\n";
        }

        private void SendTextToRightOutput(object sender, EventArgs e)
        {
            this.RightOutputText.Text += InputText.Text + "\r\n";
        }
        private void OutputEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            EventHandler checkedChangedEventHandler = null;
            if (sender == LeftPanelCheckbox)
            {
                checkedChangedEventHandler = sendTextToLeftOutputEventHandler;
            } else if (sender == RightPanleCheckbox) {
                checkedChangedEventHandler = sendTextToRightOutputEventHandler;
            }

            if ((sender as CheckBox).Checked)
            {
                OkButton.Click += checkedChangedEventHandler;
            }
            else {
                OkButton.Click -= checkedChangedEventHandler;
            }
        }
    }
}
