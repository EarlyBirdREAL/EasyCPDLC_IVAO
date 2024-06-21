
namespace EasyCPDLC
{
    partial class SettingsForm
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
    exitButton = new System.Windows.Forms.Button();
    settingsFormatPanel = new System.Windows.Forms.FlowLayoutPanel();
    cancelButton = new System.Windows.Forms.Button();
    okButton = new System.Windows.Forms.Button();
    titleLabel = new System.Windows.Forms.Label();
    SuspendLayout();
    // 
    // exitButton
    // 
    exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
    exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(28, 28, 28);
    exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    exitButton.Location = new System.Drawing.Point(600, -1);
    exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    exitButton.Name = "exitButton";
    exitButton.Size = new System.Drawing.Size(28, 28);
    exitButton.TabIndex = 10;
    exitButton.Text = "X";
    exitButton.UseVisualStyleBackColor = true;
    exitButton.Click += ExitButton_Click;
    // 
    // settingsFormatPanel
    // 
    settingsFormatPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
    settingsFormatPanel.AutoScroll = true;
    settingsFormatPanel.BackColor = System.Drawing.Color.FromArgb(5, 5, 5);
    settingsFormatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    settingsFormatPanel.Location = new System.Drawing.Point(13, 50);
    settingsFormatPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    settingsFormatPanel.Name = "settingsFormatPanel";
    settingsFormatPanel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 35);
    settingsFormatPanel.Size = new System.Drawing.Size(595, 203);
    settingsFormatPanel.TabIndex = 13;
    // 
    // cancelButton
    // 
    cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
    cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    cancelButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    cancelButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    cancelButton.Location = new System.Drawing.Point(358, 260);
    cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    cancelButton.Name = "cancelButton";
    cancelButton.Size = new System.Drawing.Size(121, 43);
    cancelButton.TabIndex = 15;
    cancelButton.Text = "CANCEL";
    cancelButton.UseVisualStyleBackColor = true;
    cancelButton.Click += CancelButton_Click;
    // 
    // okButton
    // 
    okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
    okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    okButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    okButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    okButton.Location = new System.Drawing.Point(486, 260);
    okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    okButton.Name = "okButton";
    okButton.Size = new System.Drawing.Size(121, 43);
    okButton.TabIndex = 14;
    okButton.Text = "OK";
    okButton.UseVisualStyleBackColor = true;
    okButton.Click += OkButton_Click;
    // 
    // titleLabel
    // 
    titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    titleLabel.AutoSize = true;
    titleLabel.Font = new System.Drawing.Font("Oxygen", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
    titleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
    titleLabel.Location = new System.Drawing.Point(388, 3);
    titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    titleLabel.Name = "titleLabel";
    titleLabel.Size = new System.Drawing.Size(219, 44);
    titleLabel.TabIndex = 16;
    titleLabel.Text = "IVAO CPDLC";
    // 
    // SettingsForm
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    BackColor = System.Drawing.Color.FromArgb(28, 27, 31);
    ClientSize = new System.Drawing.Size(626, 316);
    Controls.Add(titleLabel);
    Controls.Add(cancelButton);
    Controls.Add(okButton);
    Controls.Add(settingsFormatPanel);
    Controls.Add(exitButton);
    FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    MinimumSize = new System.Drawing.Size(626, 316);
    Name = "SettingsForm";
    Text = "Settings";
    ResumeLayout(false);
    PerformLayout();
}

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel settingsFormatPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}