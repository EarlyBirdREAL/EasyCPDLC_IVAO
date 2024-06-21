namespace EasyCPDLC
{
    partial class MainForm
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
    components = new System.ComponentModel.Container();
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
    exitButton = new System.Windows.Forms.Button();
    outputTable = new System.Windows.Forms.TableLayoutPanel();
    atcButton = new System.Windows.Forms.Button();
    telexButton = new System.Windows.Forms.Button();
    retrieveButton = new System.Windows.Forms.Button();
    atcUnitLabel = new System.Windows.Forms.Label();
    atcUnitDisplay = new System.Windows.Forms.Label();
    helpButton = new System.Windows.Forms.Button();
    messageFormatPanel = new System.Windows.Forms.FlowLayoutPanel();
    settingsButton = new System.Windows.Forms.Button();
    iconList = new System.Windows.Forms.ImageList(components);
    SendingProgress = new System.Windows.Forms.ProgressBar();
    titleLabel = new System.Windows.Forms.Label();
    SuspendLayout();
    // 
    // exitButton
    // 
    exitButton.AccessibleName = "Exit";
    exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
    exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(28, 28, 28);
    exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    exitButton.Location = new System.Drawing.Point(617, 4);
    exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    exitButton.Name = "exitButton";
    exitButton.Size = new System.Drawing.Size(28, 28);
    exitButton.TabIndex = 7;
    exitButton.Text = "X";
    exitButton.UseVisualStyleBackColor = true;
    exitButton.Click += ExitButton_Click;
    // 
    // outputTable
    // 
    outputTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
    outputTable.BackColor = System.Drawing.Color.FromArgb(5, 5, 5);
    outputTable.ColumnCount = 3;
    outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
    outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.5F));
    outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
    outputTable.ForeColor = System.Drawing.Color.FromArgb(5, 5, 5);
    outputTable.Location = new System.Drawing.Point(14, 76);
    outputTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    outputTable.Name = "outputTable";
    outputTable.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
    outputTable.RowCount = 1;
    outputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
    outputTable.Size = new System.Drawing.Size(616, 147);
    outputTable.TabIndex = 3;
    outputTable.TabStop = true;
    outputTable.Click += OutputTable_Click;
    // 
    // atcButton
    // 
    atcButton.Enabled = false;
    atcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    atcButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    atcButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    atcButton.Location = new System.Drawing.Point(284, 14);
    atcButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    atcButton.Name = "atcButton";
    atcButton.Size = new System.Drawing.Size(105, 55);
    atcButton.TabIndex = 2;
    atcButton.Text = "ATC";
    atcButton.UseVisualStyleBackColor = true;
    atcButton.Click += RequestButton_Click;
    // 
    // telexButton
    // 
    telexButton.Enabled = false;
    telexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    telexButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    telexButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    telexButton.Location = new System.Drawing.Point(172, 14);
    telexButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    telexButton.Name = "telexButton";
    telexButton.Size = new System.Drawing.Size(105, 55);
    telexButton.TabIndex = 1;
    telexButton.Text = "TELEX";
    telexButton.UseVisualStyleBackColor = true;
    telexButton.Click += TelexButton_Click;
    // 
    // retrieveButton
    // 
    retrieveButton.Enabled = false;
    retrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    retrieveButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    retrieveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    retrieveButton.Location = new System.Drawing.Point(14, 14);
    retrieveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    retrieveButton.Name = "retrieveButton";
    retrieveButton.Size = new System.Drawing.Size(150, 55);
    retrieveButton.TabIndex = 0;
    retrieveButton.Text = "CONNECT";
    retrieveButton.UseVisualStyleBackColor = true;
    retrieveButton.Click += RetrieveButton_Click;
    // 
    // atcUnitLabel
    // 
    atcUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    atcUnitLabel.AutoSize = true;
    atcUnitLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
    atcUnitLabel.Location = new System.Drawing.Point(403, 49);
    atcUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    atcUnitLabel.Name = "atcUnitLabel";
    atcUnitLabel.Size = new System.Drawing.Size(100, 15);
    atcUnitLabel.TabIndex = 0;
    atcUnitLabel.Text = "Current ATS Unit: ";
    // 
    // atcUnitDisplay
    // 
    atcUnitDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    atcUnitDisplay.AutoSize = true;
    atcUnitDisplay.ForeColor = System.Drawing.SystemColors.ControlLight;
    atcUnitDisplay.Location = new System.Drawing.Point(551, 49);
    atcUnitDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    atcUnitDisplay.Name = "atcUnitDisplay";
    atcUnitDisplay.Size = new System.Drawing.Size(27, 15);
    atcUnitDisplay.TabIndex = 0;
    atcUnitDisplay.Text = "----";
    // 
    // helpButton
    // 
    helpButton.AccessibleName = "About";
    helpButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
    helpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(28, 28, 28);
    helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    helpButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    helpButton.Location = new System.Drawing.Point(598, 1);
    helpButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    helpButton.Name = "helpButton";
    helpButton.Size = new System.Drawing.Size(27, 31);
    helpButton.TabIndex = 6;
    helpButton.Text = "?";
    helpButton.UseVisualStyleBackColor = true;
    helpButton.Click += HelpButton_Click;
    // 
    // messageFormatPanel
    // 
    messageFormatPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
    messageFormatPanel.AutoScroll = true;
    messageFormatPanel.BackColor = System.Drawing.Color.FromArgb(5, 5, 5);
    messageFormatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    messageFormatPanel.Location = new System.Drawing.Point(14, 76);
    messageFormatPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    messageFormatPanel.Name = "messageFormatPanel";
    messageFormatPanel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 35);
    messageFormatPanel.Size = new System.Drawing.Size(614, 146);
    messageFormatPanel.TabIndex = 4;
    messageFormatPanel.TabStop = true;
    messageFormatPanel.Visible = false;
    // 
    // settingsButton
    // 
    settingsButton.AccessibleName = "Settings";
    settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    settingsButton.BackgroundImage = Properties.Resources.cog_wheel_gear_setting;
    settingsButton.FlatAppearance.BorderSize = 0;
    settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    settingsButton.ImageIndex = 0;
    settingsButton.ImageList = iconList;
    settingsButton.Location = new System.Drawing.Point(576, 5);
    settingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    settingsButton.Name = "settingsButton";
    settingsButton.Size = new System.Drawing.Size(23, 23);
    settingsButton.TabIndex = 5;
    settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    settingsButton.UseVisualStyleBackColor = true;
    settingsButton.Click += SettingsButton_Click;
    // 
    // iconList
    // 
    iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
    iconList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("iconList.ImageStream");
    iconList.TransparentColor = System.Drawing.Color.Transparent;
    iconList.Images.SetKeyName(0, "cog-wheel-gear-setting.png");
    // 
    // SendingProgress
    // 
    SendingProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
    SendingProgress.ForeColor = System.Drawing.Color.FromArgb(28, 28, 28);
    SendingProgress.Location = new System.Drawing.Point(14, 223);
    SendingProgress.MarqueeAnimationSpeed = 10;
    SendingProgress.Maximum = 30;
    SendingProgress.Name = "SendingProgress";
    SendingProgress.Size = new System.Drawing.Size(614, 2);
    SendingProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
    SendingProgress.TabIndex = 8;
    SendingProgress.Visible = false;
    // 
    // titleLabel
    // 
    titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    titleLabel.AutoSize = true;
    titleLabel.Font = new System.Drawing.Font("Oxygen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
    titleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
    titleLabel.Location = new System.Drawing.Point(397, 14);
    titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    titleLabel.Name = "titleLabel";
    titleLabel.Size = new System.Drawing.Size(164, 34);
    titleLabel.TabIndex = 17;
    titleLabel.Text = "IVAO CPDLC";
    // 
    // MainForm
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    BackColor = System.Drawing.Color.FromArgb(28, 27, 31);
    ClientSize = new System.Drawing.Size(644, 233);
    Controls.Add(titleLabel);
    Controls.Add(SendingProgress);
    Controls.Add(settingsButton);
    Controls.Add(atcUnitDisplay);
    Controls.Add(atcUnitLabel);
    Controls.Add(retrieveButton);
    Controls.Add(telexButton);
    Controls.Add(atcButton);
    Controls.Add(exitButton);
    Controls.Add(helpButton);
    Controls.Add(messageFormatPanel);
    Controls.Add(outputTable);
    FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
    Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    MinimumSize = new System.Drawing.Size(644, 233);
    Name = "MainForm";
    Text = "9";
    FormClosing += MainForm_FormClosing;
    Load += MainForm_Load;
    MouseDown += MoveWindow;
    ResumeLayout(false);
    PerformLayout();
}

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel outputTable;
        private System.Windows.Forms.Button atcButton;
        private System.Windows.Forms.Button telexButton;
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.Label atcUnitLabel;
        private System.Windows.Forms.Label atcUnitDisplay;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.FlowLayoutPanel messageFormatPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ProgressBar SendingProgress;
    }
}

