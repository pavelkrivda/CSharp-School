namespace Exercise_Typing_with_all_ten_fingers
{
    partial class Options
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enteredPositionAnyRadioButton = new System.Windows.Forms.RadioButton();
            this.enteredPositionLastRadioButton = new System.Windows.Forms.RadioButton();
            this.enteredPositionFirstRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enteredTypeWordsRadioButton = new System.Windows.Forms.RadioButton();
            this.enteredTypeCharacterRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enteredPositionAnyRadioButton);
            this.groupBox1.Controls.Add(this.enteredPositionLastRadioButton);
            this.groupBox1.Controls.Add(this.enteredPositionFirstRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The character that must be entered:";
            // 
            // enteredPositionAnyRadioButton
            // 
            this.enteredPositionAnyRadioButton.AutoSize = true;
            this.enteredPositionAnyRadioButton.Checked = true;
            this.enteredPositionAnyRadioButton.Location = new System.Drawing.Point(6, 66);
            this.enteredPositionAnyRadioButton.Name = "enteredPositionAnyRadioButton";
            this.enteredPositionAnyRadioButton.Size = new System.Drawing.Size(43, 17);
            this.enteredPositionAnyRadioButton.TabIndex = 2;
            this.enteredPositionAnyRadioButton.TabStop = true;
            this.enteredPositionAnyRadioButton.Text = "Any";
            this.enteredPositionAnyRadioButton.UseVisualStyleBackColor = true;
            this.enteredPositionAnyRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonEnteredPosition_CheckedChanged);
            // 
            // enteredPositionLastRadioButton
            // 
            this.enteredPositionLastRadioButton.AutoSize = true;
            this.enteredPositionLastRadioButton.Location = new System.Drawing.Point(6, 42);
            this.enteredPositionLastRadioButton.Name = "enteredPositionLastRadioButton";
            this.enteredPositionLastRadioButton.Size = new System.Drawing.Size(45, 17);
            this.enteredPositionLastRadioButton.TabIndex = 1;
            this.enteredPositionLastRadioButton.Text = "Last";
            this.enteredPositionLastRadioButton.UseVisualStyleBackColor = true;
            this.enteredPositionLastRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonEnteredPosition_CheckedChanged);
            // 
            // enteredPositionFirstRadioButton
            // 
            this.enteredPositionFirstRadioButton.AutoSize = true;
            this.enteredPositionFirstRadioButton.Location = new System.Drawing.Point(6, 19);
            this.enteredPositionFirstRadioButton.Name = "enteredPositionFirstRadioButton";
            this.enteredPositionFirstRadioButton.Size = new System.Drawing.Size(44, 17);
            this.enteredPositionFirstRadioButton.TabIndex = 0;
            this.enteredPositionFirstRadioButton.Text = "First";
            this.enteredPositionFirstRadioButton.UseVisualStyleBackColor = true;
            this.enteredPositionFirstRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonEnteredPosition_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enteredTypeWordsRadioButton);
            this.groupBox2.Controls.Add(this.enteredTypeCharacterRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Write characters or words:";
            // 
            // enteredTypeWordsRadioButton
            // 
            this.enteredTypeWordsRadioButton.AutoSize = true;
            this.enteredTypeWordsRadioButton.Location = new System.Drawing.Point(6, 44);
            this.enteredTypeWordsRadioButton.Name = "enteredTypeWordsRadioButton";
            this.enteredTypeWordsRadioButton.Size = new System.Drawing.Size(56, 17);
            this.enteredTypeWordsRadioButton.TabIndex = 1;
            this.enteredTypeWordsRadioButton.Text = "Words";
            this.enteredTypeWordsRadioButton.UseVisualStyleBackColor = true;
            this.enteredTypeWordsRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonEnteredType_CheckedChanged);
            // 
            // enteredTypeCharacterRadioButton
            // 
            this.enteredTypeCharacterRadioButton.AutoSize = true;
            this.enteredTypeCharacterRadioButton.Checked = true;
            this.enteredTypeCharacterRadioButton.Location = new System.Drawing.Point(6, 20);
            this.enteredTypeCharacterRadioButton.Name = "enteredTypeCharacterRadioButton";
            this.enteredTypeCharacterRadioButton.Size = new System.Drawing.Size(76, 17);
            this.enteredTypeCharacterRadioButton.TabIndex = 0;
            this.enteredTypeCharacterRadioButton.TabStop = true;
            this.enteredTypeCharacterRadioButton.Text = "Characters";
            this.enteredTypeCharacterRadioButton.UseVisualStyleBackColor = true;
            this.enteredTypeCharacterRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonEnteredType_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton enteredPositionLastRadioButton;
        private System.Windows.Forms.RadioButton enteredPositionFirstRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton enteredPositionAnyRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton enteredTypeWordsRadioButton;
        private System.Windows.Forms.RadioButton enteredTypeCharacterRadioButton;
    }
}