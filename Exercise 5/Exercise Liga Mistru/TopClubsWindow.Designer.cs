namespace Exercise_Liga_Mistru
{
    partial class TopClubsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.countGolsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.topClubsListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počet gólů:";
            // 
            // countGolsTextBox
            // 
            this.countGolsTextBox.Location = new System.Drawing.Point(79, 17);
            this.countGolsTextBox.Name = "countGolsTextBox";
            this.countGolsTextBox.ReadOnly = true;
            this.countGolsTextBox.Size = new System.Drawing.Size(100, 20);
            this.countGolsTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.topClubsListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kluby";
            // 
            // topClubsListBox
            // 
            this.topClubsListBox.FormattingEnabled = true;
            this.topClubsListBox.Location = new System.Drawing.Point(6, 19);
            this.topClubsListBox.Name = "topClubsListBox";
            this.topClubsListBox.Size = new System.Drawing.Size(155, 121);
            this.topClubsListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(104, 193);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "OK";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // TopClubsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 227);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.countGolsTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopClubsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TopClubs";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countGolsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox topClubsListBox;
        private System.Windows.Forms.Button exitButton;
    }
}