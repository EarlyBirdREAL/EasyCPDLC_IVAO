/*  EASYCPDLC: CPDLC Client for the VATSIM Network
    Copyright (C) 2021 Joshua Seagrave joshseagrave@googlemail.com

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/



namespace EasyCPDLC
{
    partial class DataEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntry));
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.hoppieLogonLabel = new System.Windows.Forms.Label();
            this.ivaoVIDLabel = new System.Windows.Forms.Label();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundPanel2 = new EasyCPDLC.RoundPanel();
            this.ivaoVIDTextBox = new System.Windows.Forms.TextBox();
            this.roundPanel1 = new EasyCPDLC.RoundPanel();
            this.hoppieCodeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundPanel2.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font(MainForm.fonts.Families[1], 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.titleLabel.Location = new System.Drawing.Point(28, 158);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(186, 41);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "EasyCPDLC";
            // 
// exitButton
// 
exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(28, 28, 28);
exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
exitButton.Location = new System.Drawing.Point(217, 0);
exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
exitButton.Name = "exitButton";
exitButton.Size = new System.Drawing.Size(28, 28);
exitButton.TabIndex = 2;
exitButton.Text = "X";
exitButton.UseVisualStyleBackColor = true;
exitButton.Click += ExitButton_Click;
// 
// hoppieLogonLabel
// 
hoppieLogonLabel.AutoSize = true;
hoppieLogonLabel.Font = new System.Drawing.Font("Oxygen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
hoppieLogonLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
hoppieLogonLabel.Location = new System.Drawing.Point(48, 217);
hoppieLogonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
hoppieLogonLabel.Name = "hoppieLogonLabel";
hoppieLogonLabel.Size = new System.Drawing.Size(145, 19);
hoppieLogonLabel.TabIndex = 3;
hoppieLogonLabel.Text = "Hoppie Logon Code";
// 
// ivaoVIDLabel
// 
ivaoVIDLabel.AutoSize = true;
ivaoVIDLabel.Font = new System.Drawing.Font("Oxygen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
ivaoVIDLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
ivaoVIDLabel.Location = new System.Drawing.Point(88, 281);
ivaoVIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
ivaoVIDLabel.Name = "ivaoVIDLabel";
ivaoVIDLabel.Size = new System.Drawing.Size(71, 19);
ivaoVIDLabel.TabIndex = 4;
ivaoVIDLabel.Text = "IVAO VID";
// 
// rememberCheckBox
// 
rememberCheckBox.AutoSize = true;
rememberCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
rememberCheckBox.Font = new System.Drawing.Font("Oxygen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
rememberCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
rememberCheckBox.Location = new System.Drawing.Point(56, 342);
rememberCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
rememberCheckBox.Name = "rememberCheckBox";
rememberCheckBox.Size = new System.Drawing.Size(130, 23);
rememberCheckBox.TabIndex = 7;
rememberCheckBox.Text = "Remember Me?";
rememberCheckBox.UseVisualStyleBackColor = true;
// 
// connectButton
// 
connectButton.Enabled = false;
connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
connectButton.Font = new System.Drawing.Font("Oxygen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
connectButton.ForeColor = System.Drawing.SystemColors.ControlLight;
connectButton.Location = new System.Drawing.Point(40, 380);
connectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
connectButton.Name = "connectButton";
connectButton.Size = new System.Drawing.Size(163, 33);
connectButton.TabIndex = 8;
connectButton.Text = "Connect";
connectButton.UseVisualStyleBackColor = true;
connectButton.Click += ConnectButton_Click;
// 
// pictureBox1
// 
            this.pictureBox1.Image = global::EasyCPDLC.Properties.Resources.Stretchboard;
            this.pictureBox1.Location = new System.Drawing.Point(45, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 130);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataEntry_MouseDown);
            // 
// roundPanel2
// 
roundPanel2.BackColor = System.Drawing.Color.FromArgb(28, 27, 31);
roundPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
roundPanel2.Controls.Add(ivaoVIDTextBox);
roundPanel2.Location = new System.Drawing.Point(17, 302);
roundPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
roundPanel2.Name = "roundPanel2";
roundPanel2.Size = new System.Drawing.Size(208, 34);
pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
roundPanel2.TabIndex = 11;
// 
// ivaoVIDTextBox
// 
ivaoVIDTextBox.BackColor = System.Drawing.Color.FromArgb(28, 27, 31);
ivaoVIDTextBox.Font = new System.Drawing.Font("Oxygen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
ivaoVIDTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
ivaoVIDTextBox.Location = new System.Drawing.Point(7, 7);
ivaoVIDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
ivaoVIDTextBox.MaxLength = 7;
ivaoVIDTextBox.Name = "ivaoVIDTextBox";
ivaoVIDTextBox.PlaceholderText = "Your IVAO VID";
ivaoVIDTextBox.Size = new System.Drawing.Size(192, 26);
ivaoVIDTextBox.TabIndex = 1;
ivaoVIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
ivaoVIDTextBox.TextChanged += IvaoVidTextBoxTextChanged;
ivaoVIDTextBox.KeyPress += NumsOnly;
// 
// roundPanel1
// 
roundPanel1.BackColor = System.Drawing.Color.FromArgb(28, 27, 31);
roundPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
roundPanel1.Controls.Add(hoppieCodeTextBox);
roundPanel1.Location = new System.Drawing.Point(17, 239);
roundPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
roundPanel1.Name = "roundPanel1";
roundPanel1.Size = new System.Drawing.Size(208, 34);
roundPanel1.TabIndex = 10;
// 
// hoppieCodeTextBox
// 
hoppieCodeTextBox.BackColor = System.Drawing.Color.FromArgb(28, 27, 31);
hoppieCodeTextBox.Font = new System.Drawing.Font("Oxygen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
hoppieCodeTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
hoppieCodeTextBox.Location = new System.Drawing.Point(7, 7);
hoppieCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
hoppieCodeTextBox.MaxLength = 18;
hoppieCodeTextBox.Name = "hoppieCodeTextBox";
hoppieCodeTextBox.PlaceholderText = "Your Hoppie Code";
hoppieCodeTextBox.Size = new System.Drawing.Size(192, 26);
hoppieCodeTextBox.TabIndex = 0;
hoppieCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
hoppieCodeTextBox.TextChanged += HoppieCodeTextBox_TextChanged;
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(244, 433);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.rememberCheckBox);
            this.Controls.Add(this.ivaoVIDLabel);
            this.Controls.Add(this.hoppieLogonLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataEntry";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataEntry_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label hoppieLogonLabel;
        private System.Windows.Forms.Label ivaoVIDLabel;
        private System.Windows.Forms.CheckBox rememberCheckBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.TextBox hoppieCodeTextBox;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.TextBox ivaoVIDTextBox;
    }
}