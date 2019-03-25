namespace Exercise_Liga_Mistru
{
    partial class MainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.constrolsButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.findBestClubButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.editPlayerButton = new System.Windows.Forms.Button();
            this.registerHandlerButton = new System.Windows.Forms.Button();
            this.unregisterHandlerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playersListView = new System.Windows.Forms.ListView();
            this.playerNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerClubsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerGolsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.constrolsButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventListBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 311);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.Controls.Add(this.constrolsButtonsTableLayoutPanel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.playersListView, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(493, 211);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // constrolsButtonsTableLayoutPanel
            // 
            this.constrolsButtonsTableLayoutPanel.ColumnCount = 1;
            this.constrolsButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.constrolsButtonsTableLayoutPanel.Controls.Add(this.addPlayerButton, 0, 0);
            this.constrolsButtonsTableLayoutPanel.Controls.Add(this.findBestClubButton, 0, 3);
            this.constrolsButtonsTableLayoutPanel.Controls.Add(this.removePlayerButton, 0, 1);
            this.constrolsButtonsTableLayoutPanel.Controls.Add(this.editPlayerButton, 0, 2);
            this.constrolsButtonsTableLayoutPanel.Controls.Add(this.registerHandlerButton, 0, 4);
            this.constrolsButtonsTableLayoutPanel.Controls.Add(this.unregisterHandlerButton, 0, 5);
            this.constrolsButtonsTableLayoutPanel.Controls.Add(this.exitButton, 0, 6);
            this.constrolsButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constrolsButtonsTableLayoutPanel.Location = new System.Drawing.Point(393, 0);
            this.constrolsButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.constrolsButtonsTableLayoutPanel.Name = "constrolsButtonsTableLayoutPanel";
            this.constrolsButtonsTableLayoutPanel.RowCount = 8;
            this.constrolsButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.constrolsButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.constrolsButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.constrolsButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.constrolsButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.constrolsButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.constrolsButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.constrolsButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.constrolsButtonsTableLayoutPanel.Size = new System.Drawing.Size(100, 211);
            this.constrolsButtonsTableLayoutPanel.TabIndex = 4;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayerButton.Location = new System.Drawing.Point(3, 3);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(94, 24);
            this.addPlayerButton.TabIndex = 0;
            this.addPlayerButton.Text = "Přidej";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click_1);
            // 
            // findBestClubButton
            // 
            this.findBestClubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findBestClubButton.Enabled = false;
            this.findBestClubButton.Location = new System.Drawing.Point(3, 93);
            this.findBestClubButton.Name = "findBestClubButton";
            this.findBestClubButton.Size = new System.Drawing.Size(94, 24);
            this.findBestClubButton.TabIndex = 3;
            this.findBestClubButton.Text = "Nejlepší klub";
            this.findBestClubButton.UseVisualStyleBackColor = true;
            this.findBestClubButton.Click += new System.EventHandler(this.findBestClubButton_Click_1);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removePlayerButton.Enabled = false;
            this.removePlayerButton.Location = new System.Drawing.Point(3, 33);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(94, 24);
            this.removePlayerButton.TabIndex = 1;
            this.removePlayerButton.Text = "Vymaž";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click_1);
            // 
            // editPlayerButton
            // 
            this.editPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPlayerButton.Enabled = false;
            this.editPlayerButton.Location = new System.Drawing.Point(3, 63);
            this.editPlayerButton.Name = "editPlayerButton";
            this.editPlayerButton.Size = new System.Drawing.Size(94, 24);
            this.editPlayerButton.TabIndex = 2;
            this.editPlayerButton.Text = "Upravit";
            this.editPlayerButton.UseVisualStyleBackColor = true;
            this.editPlayerButton.Click += new System.EventHandler(this.editPlayerButton_Click_1);
            // 
            // registerHandlerButton
            // 
            this.registerHandlerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerHandlerButton.Location = new System.Drawing.Point(3, 123);
            this.registerHandlerButton.Name = "registerHandlerButton";
            this.registerHandlerButton.Size = new System.Drawing.Size(94, 24);
            this.registerHandlerButton.TabIndex = 4;
            this.registerHandlerButton.Text = "Registrovat";
            this.registerHandlerButton.UseVisualStyleBackColor = true;
            this.registerHandlerButton.Click += new System.EventHandler(this.registerHandlerButton_Click_1);
            // 
            // unregisterHandlerButton
            // 
            this.unregisterHandlerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unregisterHandlerButton.Enabled = false;
            this.unregisterHandlerButton.Location = new System.Drawing.Point(3, 153);
            this.unregisterHandlerButton.Name = "unregisterHandlerButton";
            this.unregisterHandlerButton.Size = new System.Drawing.Size(94, 24);
            this.unregisterHandlerButton.TabIndex = 5;
            this.unregisterHandlerButton.Text = "Zrušit";
            this.unregisterHandlerButton.UseVisualStyleBackColor = true;
            this.unregisterHandlerButton.Click += new System.EventHandler(this.unregisterHandlerButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(3, 183);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 24);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Konec";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // playersListView
            // 
            this.playersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerNameColumnHeader,
            this.playerClubsColumnHeader,
            this.playerGolsColumnHeader});
            this.playersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersListView.Location = new System.Drawing.Point(3, 3);
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(387, 205);
            this.playersListView.TabIndex = 0;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            this.playersListView.View = System.Windows.Forms.View.Details;
            this.playersListView.SelectedIndexChanged += new System.EventHandler(this.playersListView_SelectedIndexChanged);
            // 
            // playerNameColumnHeader
            // 
            this.playerNameColumnHeader.Text = "Jméno";
            this.playerNameColumnHeader.Width = 145;
            // 
            // playerClubsColumnHeader
            // 
            this.playerClubsColumnHeader.Text = "Klub";
            this.playerClubsColumnHeader.Width = 167;
            // 
            // playerGolsColumnHeader
            // 
            this.playerGolsColumnHeader.Text = "Góly";
            // 
            // eventListBox
            // 
            this.eventListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.Location = new System.Drawing.Point(3, 214);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(487, 94);
            this.eventListBox.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(509, 350);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.constrolsButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.TableLayoutPanel constrolsButtonsTableLayoutPanel;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button findBestClubButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button editPlayerButton;
        private System.Windows.Forms.Button registerHandlerButton;
        private System.Windows.Forms.Button unregisterHandlerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView playersListView;
        private System.Windows.Forms.ColumnHeader playerNameColumnHeader;
        private System.Windows.Forms.ColumnHeader playerClubsColumnHeader;
        private System.Windows.Forms.ColumnHeader playerGolsColumnHeader;
    }
}

