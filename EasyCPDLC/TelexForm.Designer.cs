namespace EasyCPDLC
{
    partial class TelexForm
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
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelexForm));
    messageFormatPanel = new System.Windows.Forms.FlowLayoutPanel();
    clearButton = new System.Windows.Forms.Button();
    sendButton = new System.Windows.Forms.Button();
    exitButton = new System.Windows.Forms.Button();
    freeTextButton = new System.Windows.Forms.Button();
    metarButton = new System.Windows.Forms.Button();
    atisButton = new System.Windows.Forms.Button();
    radioContainer = new System.Windows.Forms.Panel();
    atisRadioButton = new System.Windows.Forms.RadioButton();
    metarRadioButton = new System.Windows.Forms.RadioButton();
    freeTextRadioButton = new System.Windows.Forms.RadioButton();
    titleLabel = new System.Windows.Forms.Label();
    radioContainer.SuspendLayout();
    SuspendLayout();
    // 
    // messageFormatPanel
    // 
    messageFormatPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
    messageFormatPanel.AutoScroll = true;
    messageFormatPanel.BackColor = System.Drawing.Color.FromArgb(5, 5, 5);
    messageFormatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    messageFormatPanel.Location = new System.Drawing.Point(16, 63);
    messageFormatPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
    messageFormatPanel.Name = "messageFormatPanel";
    messageFormatPanel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 35);
    messageFormatPanel.Size = new System.Drawing.Size(588, 146);
    messageFormatPanel.TabIndex = 3;
    // 
    // clearButton
    // 
    clearButton.AccessibleDescription = "Clear Telex";
    clearButton.AccessibleName = "Clear";
    clearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
    clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    clearButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    clearButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    clearButton.Location = new System.Drawing.Point(355, 219);
    clearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    clearButton.Name = "clearButton";
    clearButton.Size = new System.Drawing.Size(121, 43);
    clearButton.TabIndex = 4;
    clearButton.Text = "CLEAR";
    clearButton.UseVisualStyleBackColor = true;
    clearButton.Click += ResetPanel;
    // 
    // sendButton
    // 
    sendButton.AccessibleDescription = "Send Telex Message";
    sendButton.AccessibleName = "Send";
    sendButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
    sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    sendButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    sendButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    sendButton.Location = new System.Drawing.Point(483, 219);
    sendButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    sendButton.Name = "sendButton";
    sendButton.Size = new System.Drawing.Size(121, 43);
    sendButton.TabIndex = 5;
    sendButton.Text = "SEND";
    sendButton.UseVisualStyleBackColor = true;
    sendButton.Click += SendButton_Click;
    // 
    // exitButton
    // 
    exitButton.AccessibleDescription = "Exit Telex Form";
    exitButton.AccessibleName = "Exit";
    exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
    exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(28, 28, 28);
    exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    exitButton.Location = new System.Drawing.Point(594, 0);
    exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    exitButton.Name = "exitButton";
    exitButton.Size = new System.Drawing.Size(28, 28);
    exitButton.TabIndex = 6;
    exitButton.Text = "X";
    exitButton.UseVisualStyleBackColor = true;
    exitButton.Click += ExitButton_Click;
    // 
    // freeTextButton
    // 
    freeTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    freeTextButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    freeTextButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    freeTextButton.Location = new System.Drawing.Point(16, 12);
    freeTextButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    freeTextButton.Name = "freeTextButton";
    freeTextButton.Size = new System.Drawing.Size(117, 43);
    freeTextButton.TabIndex = 0;
    freeTextButton.Text = "FREE TEXT";
    freeTextButton.UseVisualStyleBackColor = true;
    freeTextButton.Click += FreeTextButton_Click;
    // 
    // metarButton
    // 
    metarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    metarButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    metarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    metarButton.Location = new System.Drawing.Point(140, 12);
    metarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    metarButton.Name = "metarButton";
    metarButton.Size = new System.Drawing.Size(117, 43);
    metarButton.TabIndex = 1;
    metarButton.Text = "METAR";
    metarButton.UseVisualStyleBackColor = true;
    metarButton.Click += MetarButton_Click;
    // 
    // atisButton
    // 
    atisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    atisButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    atisButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    atisButton.Location = new System.Drawing.Point(264, 12);
    atisButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    atisButton.Name = "atisButton";
    atisButton.Size = new System.Drawing.Size(117, 43);
    atisButton.TabIndex = 2;
    atisButton.Text = "ATIS";
    atisButton.UseVisualStyleBackColor = true;
    atisButton.Click += AtisButton_Click;
    // 
    // radioContainer
    // 
    radioContainer.Controls.Add(atisRadioButton);
    radioContainer.Controls.Add(metarRadioButton);
    radioContainer.Controls.Add(freeTextRadioButton);
    radioContainer.Location = new System.Drawing.Point(231, 219);
    radioContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    radioContainer.Name = "radioContainer";
    radioContainer.Size = new System.Drawing.Size(72, 30);
    radioContainer.TabIndex = 15;
    radioContainer.Visible = false;
    // 
    // atisRadioButton
    // 
    atisRadioButton.AutoSize = true;
    atisRadioButton.Location = new System.Drawing.Point(51, 8);
    atisRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    atisRadioButton.Name = "atisRadioButton";
    atisRadioButton.Size = new System.Drawing.Size(14, 13);
    atisRadioButton.TabIndex = 2;
    atisRadioButton.TabStop = true;
    atisRadioButton.UseVisualStyleBackColor = true;
    atisRadioButton.Visible = false;
    // 
    // metarRadioButton
    // 
    metarRadioButton.AutoSize = true;
    metarRadioButton.Location = new System.Drawing.Point(28, 8);
    metarRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    metarRadioButton.Name = "metarRadioButton";
    metarRadioButton.Size = new System.Drawing.Size(14, 13);
    metarRadioButton.TabIndex = 1;
    metarRadioButton.TabStop = true;
    metarRadioButton.UseVisualStyleBackColor = true;
    metarRadioButton.Visible = false;
    // 
    // freeTextRadioButton
    // 
    freeTextRadioButton.AutoSize = true;
    freeTextRadioButton.Location = new System.Drawing.Point(5, 8);
    freeTextRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    freeTextRadioButton.Name = "freeTextRadioButton";
    freeTextRadioButton.Size = new System.Drawing.Size(14, 13);
    freeTextRadioButton.TabIndex = 0;
    freeTextRadioButton.TabStop = true;
    freeTextRadioButton.UseVisualStyleBackColor = true;
    freeTextRadioButton.Visible = false;
    // 
    // titleLabel
    // 
    titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    titleLabel.AutoSize = true;
    titleLabel.Font = new System.Drawing.Font("Oxygen", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
    titleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
    titleLabel.Location = new System.Drawing.Point(385, 12);
    titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    titleLabel.Name = "titleLabel";
    titleLabel.Size = new System.Drawing.Size(219, 44);
    titleLabel.TabIndex = 17;
    titleLabel.Text = "IVAO CPDLC";
    // 
    // TelexForm
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    BackColor = System.Drawing.Color.FromArgb(28, 27, 31);
    BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
    ClientSize = new System.Drawing.Size(621, 278);
    Controls.Add(titleLabel);
    Controls.Add(radioContainer);
    Controls.Add(atisButton);
    Controls.Add(metarButton);
    Controls.Add(freeTextButton);
    Controls.Add(exitButton);
    Controls.Add(sendButton);
    Controls.Add(clearButton);
    Controls.Add(messageFormatPanel);
    FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
    Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    MinimumSize = new System.Drawing.Size(621, 278);
    Name = "TelexForm";
    Text = "TelexForm";
    FormClosing += TelexForm_FormClosing;
    Load += ReloadPanel;
    MouseDown += WindowDrag;
    radioContainer.ResumeLayout(false);
    radioContainer.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
}

        #endregion
        private System.Windows.Forms.FlowLayoutPanel messageFormatPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button freeTextButton;
        private System.Windows.Forms.Button metarButton;
        private System.Windows.Forms.Button atisButton;
        private System.Windows.Forms.Panel radioContainer;
        private System.Windows.Forms.RadioButton atisRadioButton;
        private System.Windows.Forms.RadioButton metarRadioButton;
        private System.Windows.Forms.RadioButton freeTextRadioButton;
    }
}