namespace MessageLogger
{
    partial class MessageLoggerApplicationForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RightPanleCheckbox = new System.Windows.Forms.CheckBox();
            this.LeftPanelCheckbox = new System.Windows.Forms.CheckBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.LeftOutputText = new System.Windows.Forms.TextBox();
            this.RightOutputText = new System.Windows.Forms.TextBox();
            this.LeftOutputGroup = new System.Windows.Forms.GroupBox();
            this.RightOutputGroup = new System.Windows.Forms.GroupBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.LeftOutputGroup.SuspendLayout();
            this.RightOutputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(417, 112);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RightPanleCheckbox);
            this.panel1.Controls.Add(this.LeftPanelCheckbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 23);
            this.panel1.TabIndex = 1;
            // 
            // RightPanleCheckbox
            // 
            this.RightPanleCheckbox.AutoSize = true;
            this.RightPanleCheckbox.Location = new System.Drawing.Point(91, 5);
            this.RightPanleCheckbox.Name = "RightPanleCheckbox";
            this.RightPanleCheckbox.Size = new System.Drawing.Size(80, 17);
            this.RightPanleCheckbox.TabIndex = 1;
            this.RightPanleCheckbox.Text = "Right panel";
            this.RightPanleCheckbox.UseVisualStyleBackColor = true;
            // 
            // LeftPanelCheckbox
            // 
            this.LeftPanelCheckbox.AutoSize = true;
            this.LeftPanelCheckbox.Location = new System.Drawing.Point(4, 5);
            this.LeftPanelCheckbox.Name = "LeftPanelCheckbox";
            this.LeftPanelCheckbox.Size = new System.Drawing.Size(73, 17);
            this.LeftPanelCheckbox.TabIndex = 0;
            this.LeftPanelCheckbox.Text = "Left panel";
            this.LeftPanelCheckbox.UseVisualStyleBackColor = true;
            this.LeftPanelCheckbox.CheckedChanged += new System.EventHandler(this.OutputEnableCheckbox_CheckedChanged);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(12, 114);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(250, 42);
            this.InputText.TabIndex = 2;
            // 
            // LeftOutputText
            // 
            this.LeftOutputText.Enabled = false;
            this.LeftOutputText.Location = new System.Drawing.Point(6, 19);
            this.LeftOutputText.Multiline = true;
            this.LeftOutputText.Name = "LeftOutputText";
            this.LeftOutputText.Size = new System.Drawing.Size(232, 342);
            this.LeftOutputText.TabIndex = 0;
            // 
            // RightOutputText
            // 
            this.RightOutputText.Enabled = false;
            this.RightOutputText.Location = new System.Drawing.Point(6, 19);
            this.RightOutputText.Multiline = true;
            this.RightOutputText.Name = "RightOutputText";
            this.RightOutputText.Size = new System.Drawing.Size(228, 342);
            this.RightOutputText.TabIndex = 0;
            // 
            // LeftOutputGroup
            // 
            this.LeftOutputGroup.Controls.Add(this.LeftOutputText);
            this.LeftOutputGroup.Location = new System.Drawing.Point(6, 162);
            this.LeftOutputGroup.Name = "LeftOutputGroup";
            this.LeftOutputGroup.Size = new System.Drawing.Size(246, 367);
            this.LeftOutputGroup.TabIndex = 3;
            this.LeftOutputGroup.TabStop = false;
            this.LeftOutputGroup.Text = "Left output";
            // 
            // RightOutputGroup
            // 
            this.RightOutputGroup.Controls.Add(this.RightOutputText);
            this.RightOutputGroup.Location = new System.Drawing.Point(258, 162);
            this.RightOutputGroup.Name = "RightOutputGroup";
            this.RightOutputGroup.Size = new System.Drawing.Size(240, 367);
            this.RightOutputGroup.TabIndex = 4;
            this.RightOutputGroup.TabStop = false;
            this.RightOutputGroup.Text = "Right output";
            this.RightOutputGroup.Enter += new System.EventHandler(this.RightOutputGroup_Enter);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(9, 98);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(76, 13);
            this.InputLabel.TabIndex = 5;
            this.InputLabel.Text = "Input message";
            // 
            // MessageLoggerApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 545);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.RightOutputGroup);
            this.Controls.Add(this.LeftOutputGroup);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OkButton);
            this.Name = "MessageLoggerApplicationForm";
            this.Text = "Message logger application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LeftOutputGroup.ResumeLayout(false);
            this.LeftOutputGroup.PerformLayout();
            this.RightOutputGroup.ResumeLayout(false);
            this.RightOutputGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox RightPanleCheckbox;
        private System.Windows.Forms.CheckBox LeftPanelCheckbox;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox LeftOutputText;
        private System.Windows.Forms.TextBox RightOutputText;
        private System.Windows.Forms.GroupBox LeftOutputGroup;
        private System.Windows.Forms.GroupBox RightOutputGroup;
        private System.Windows.Forms.Label InputLabel;
    }
}

