namespace EasyCPDLC
{
    partial class RequestForm
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
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
    titleLabel = new System.Windows.Forms.Label();
    exitButton = new System.Windows.Forms.Button();
    sendButton = new System.Windows.Forms.Button();
    clearButton = new System.Windows.Forms.Button();
    pdcButton = new System.Windows.Forms.Button();
    logonButton = new System.Windows.Forms.Button();
    requestButton = new System.Windows.Forms.Button();
    radioContainer = new System.Windows.Forms.Panel();
    ocnClxRadioButton = new System.Windows.Forms.RadioButton();
    reportRadioButton = new System.Windows.Forms.RadioButton();
    requestRadioButton = new System.Windows.Forms.RadioButton();
    logonRadioButton = new System.Windows.Forms.RadioButton();
    depClxRadioButton = new System.Windows.Forms.RadioButton();
    reportButton = new System.Windows.Forms.Button();
    requestContainer = new System.Windows.Forms.Panel();
    wcwRadioButton = new System.Windows.Forms.RadioButton();
    directRadioButton = new System.Windows.Forms.RadioButton();
    speedRadioButton = new System.Windows.Forms.RadioButton();
    levelRadioButton = new System.Windows.Forms.RadioButton();
    messageFormatPanel = new System.Windows.Forms.TableLayoutPanel();
    radioContainer.SuspendLayout();
    requestContainer.SuspendLayout();
    SuspendLayout();
    // 
    // titleLabel
    // 
    titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    titleLabel.AutoSize = true;
    titleLabel.Font = new System.Drawing.Font("Oxygen", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
    titleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
    titleLabel.Location = new System.Drawing.Point(478, 8);
    titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    titleLabel.Name = "titleLabel";
    titleLabel.Size = new System.Drawing.Size(219, 44);
    titleLabel.TabIndex = 0;
    titleLabel.Text = "IVAO CPDLC";
    titleLabel.MouseDown += WindowDrag;
    // 
    // exitButton
    // 
    exitButton.AccessibleDescription = "Exit CPDLC Form";
    exitButton.AccessibleName = "Exit";
    exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
    exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
    exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(28, 28, 28);
    exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    exitButton.Location = new System.Drawing.Point(686, 0);
    exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    exitButton.Name = "exitButton";
    exitButton.Size = new System.Drawing.Size(28, 28);
    exitButton.TabIndex = 8;
    exitButton.Text = "X";
    exitButton.UseVisualStyleBackColor = true;
    exitButton.Click += ExitButton_Click;
    // 
    // sendButton
    // 
    sendButton.AccessibleDescription = "Send Request";
    sendButton.AccessibleName = "Send";
    sendButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
    sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    sendButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    sendButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    sendButton.Location = new System.Drawing.Point(576, 280);
    sendButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    sendButton.Name = "sendButton";
    sendButton.Size = new System.Drawing.Size(121, 43);
    sendButton.TabIndex = 7;
    sendButton.Text = "SEND";
    sendButton.UseVisualStyleBackColor = true;
    sendButton.Click += SendButton_Click;
    // 
    // clearButton
    // 
    clearButton.AccessibleDescription = "Clear Request";
    clearButton.AccessibleName = "Clear";
    clearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
    clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    clearButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    clearButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    clearButton.Location = new System.Drawing.Point(448, 280);
    clearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    clearButton.Name = "clearButton";
    clearButton.Size = new System.Drawing.Size(121, 43);
    clearButton.TabIndex = 6;
    clearButton.Text = "CLEAR";
    clearButton.UseVisualStyleBackColor = true;
    clearButton.Click += ClearButton_Click;
    // 
    // pdcButton
    // 
    pdcButton.AccessibleName = "Request Clearance";
    pdcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    pdcButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    pdcButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    pdcButton.Location = new System.Drawing.Point(14, 9);
    pdcButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    pdcButton.Name = "pdcButton";
    pdcButton.Size = new System.Drawing.Size(110, 43);
    pdcButton.TabIndex = 1;
    pdcButton.Text = "REQ CLX";
    pdcButton.UseVisualStyleBackColor = true;
    pdcButton.Click += PdcButton_Click;
    // 
    // logonButton
    // 
    logonButton.AccessibleName = "Logon";
    logonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    logonButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    logonButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    logonButton.Location = new System.Drawing.Point(131, 9);
    logonButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    logonButton.Name = "logonButton";
    logonButton.Size = new System.Drawing.Size(110, 43);
    logonButton.TabIndex = 2;
    logonButton.Text = "LOGON";
    logonButton.UseVisualStyleBackColor = true;
    logonButton.Click += LogonButton_Click;
    // 
    // requestButton
    // 
    requestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    requestButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    requestButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    requestButton.Location = new System.Drawing.Point(247, 9);
    requestButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    requestButton.Name = "requestButton";
    requestButton.Size = new System.Drawing.Size(110, 43);
    requestButton.TabIndex = 3;
    requestButton.Text = "REQUEST";
    requestButton.UseVisualStyleBackColor = true;
    requestButton.Click += RequestButton_Click;
    // 
    // radioContainer
    // 
    radioContainer.Controls.Add(ocnClxRadioButton);
    radioContainer.Controls.Add(reportRadioButton);
    radioContainer.Controls.Add(requestRadioButton);
    radioContainer.Controls.Add(logonRadioButton);
    radioContainer.Controls.Add(depClxRadioButton);
    radioContainer.Location = new System.Drawing.Point(280, 272);
    radioContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    radioContainer.Name = "radioContainer";
    radioContainer.Size = new System.Drawing.Size(119, 30);
    radioContainer.TabIndex = 12;
    radioContainer.Visible = false;
    // 
    // ocnClxRadioButton
    // 
    ocnClxRadioButton.AutoSize = true;
    ocnClxRadioButton.Location = new System.Drawing.Point(97, 7);
    ocnClxRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    ocnClxRadioButton.Name = "ocnClxRadioButton";
    ocnClxRadioButton.Size = new System.Drawing.Size(14, 13);
    ocnClxRadioButton.TabIndex = 5;
    ocnClxRadioButton.TabStop = true;
    ocnClxRadioButton.UseVisualStyleBackColor = true;
    ocnClxRadioButton.Visible = false;
    // 
    // reportRadioButton
    // 
    reportRadioButton.AutoSize = true;
    reportRadioButton.Location = new System.Drawing.Point(75, 8);
    reportRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    reportRadioButton.Name = "reportRadioButton";
    reportRadioButton.Size = new System.Drawing.Size(14, 13);
    reportRadioButton.TabIndex = 3;
    reportRadioButton.TabStop = true;
    reportRadioButton.UseVisualStyleBackColor = true;
    reportRadioButton.Visible = false;
    // 
    // requestRadioButton
    // 
    requestRadioButton.AutoSize = true;
    requestRadioButton.Location = new System.Drawing.Point(51, 8);
    requestRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    requestRadioButton.Name = "requestRadioButton";
    requestRadioButton.Size = new System.Drawing.Size(14, 13);
    requestRadioButton.TabIndex = 2;
    requestRadioButton.TabStop = true;
    requestRadioButton.UseVisualStyleBackColor = true;
    requestRadioButton.Visible = false;
    // 
    // logonRadioButton
    // 
    logonRadioButton.AutoSize = true;
    logonRadioButton.Location = new System.Drawing.Point(28, 8);
    logonRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    logonRadioButton.Name = "logonRadioButton";
    logonRadioButton.Size = new System.Drawing.Size(14, 13);
    logonRadioButton.TabIndex = 1;
    logonRadioButton.TabStop = true;
    logonRadioButton.UseVisualStyleBackColor = true;
    logonRadioButton.Visible = false;
    // 
    // depClxRadioButton
    // 
    depClxRadioButton.AutoSize = true;
    depClxRadioButton.Location = new System.Drawing.Point(5, 8);
    depClxRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    depClxRadioButton.Name = "depClxRadioButton";
    depClxRadioButton.Size = new System.Drawing.Size(14, 13);
    depClxRadioButton.TabIndex = 0;
    depClxRadioButton.TabStop = true;
    depClxRadioButton.UseVisualStyleBackColor = true;
    depClxRadioButton.Visible = false;
    // 
    // reportButton
    // 
    reportButton.Enabled = false;
    reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    reportButton.ForeColor = System.Drawing.SystemColors.ControlLight;
    reportButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
    reportButton.Location = new System.Drawing.Point(364, 9);
    reportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    reportButton.Name = "reportButton";
    reportButton.Size = new System.Drawing.Size(110, 43);
    reportButton.TabIndex = 4;
    reportButton.Text = "REPORT";
    reportButton.UseVisualStyleBackColor = true;
    reportButton.Click += ReportButton_Click;
    // 
    // requestContainer
    // 
    requestContainer.Controls.Add(wcwRadioButton);
    requestContainer.Controls.Add(directRadioButton);
    requestContainer.Controls.Add(speedRadioButton);
    requestContainer.Controls.Add(levelRadioButton);
    requestContainer.Location = new System.Drawing.Point(178, 272);
    requestContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    requestContainer.Name = "requestContainer";
    requestContainer.Size = new System.Drawing.Size(94, 30);
    requestContainer.TabIndex = 13;
    requestContainer.Visible = false;
    // 
    // wcwRadioButton
    // 
    wcwRadioButton.AutoSize = true;
    wcwRadioButton.Location = new System.Drawing.Point(75, 8);
    wcwRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    wcwRadioButton.Name = "wcwRadioButton";
    wcwRadioButton.Size = new System.Drawing.Size(14, 13);
    wcwRadioButton.TabIndex = 3;
    wcwRadioButton.TabStop = true;
    wcwRadioButton.UseVisualStyleBackColor = true;
    wcwRadioButton.Visible = false;
    // 
    // directRadioButton
    // 
    directRadioButton.AutoSize = true;
    directRadioButton.Location = new System.Drawing.Point(51, 8);
    directRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    directRadioButton.Name = "directRadioButton";
    directRadioButton.Size = new System.Drawing.Size(14, 13);
    directRadioButton.TabIndex = 2;
    directRadioButton.TabStop = true;
    directRadioButton.UseVisualStyleBackColor = true;
    directRadioButton.Visible = false;
    // 
    // speedRadioButton
    // 
    speedRadioButton.AutoSize = true;
    speedRadioButton.Location = new System.Drawing.Point(28, 8);
    speedRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    speedRadioButton.Name = "speedRadioButton";
    speedRadioButton.Size = new System.Drawing.Size(14, 13);
    speedRadioButton.TabIndex = 1;
    speedRadioButton.TabStop = true;
    speedRadioButton.UseVisualStyleBackColor = true;
    speedRadioButton.Visible = false;
    // 
    // levelRadioButton
    // 
    levelRadioButton.AutoSize = true;
    levelRadioButton.Location = new System.Drawing.Point(5, 8);
    levelRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    levelRadioButton.Name = "levelRadioButton";
    levelRadioButton.Size = new System.Drawing.Size(14, 13);
    levelRadioButton.TabIndex = 0;
    levelRadioButton.TabStop = true;
    levelRadioButton.UseVisualStyleBackColor = true;
    levelRadioButton.Visible = false;
    // 
    // messageFormatPanel
    // 
    messageFormatPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
    messageFormatPanel.BackColor = System.Drawing.Color.FromArgb(5, 5, 5);
    messageFormatPanel.ColumnCount = 6;
    messageFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
    messageFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
    messageFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
    messageFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
    messageFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
    messageFormatPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
    messageFormatPanel.Location = new System.Drawing.Point(14, 58);
    messageFormatPanel.Name = "messageFormatPanel";
    messageFormatPanel.RowCount = 7;
    messageFormatPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
    messageFormatPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
    messageFormatPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
    messageFormatPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
    messageFormatPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
    messageFormatPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
    messageFormatPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
    messageFormatPanel.Size = new System.Drawing.Size(683, 215);
    messageFormatPanel.TabIndex = 5;
    // 
    // RequestForm
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    BackColor = System.Drawing.Color.FromArgb(28, 27, 31);
    ClientSize = new System.Drawing.Size(714, 335);
    Controls.Add(messageFormatPanel);
    Controls.Add(requestContainer);
    Controls.Add(reportButton);
    Controls.Add(requestButton);
    Controls.Add(radioContainer);
    Controls.Add(logonButton);
    Controls.Add(clearButton);
    Controls.Add(sendButton);
    Controls.Add(pdcButton);
    Controls.Add(exitButton);
    Controls.Add(titleLabel);
    FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
    Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    MaximumSize = new System.Drawing.Size(714, 335);
    MinimumSize = new System.Drawing.Size(714, 335);
    Name = "RequestForm";
    Text = "RequestForm";
    FormClosing += RequestForm_FormClosing;
    Load += RequestForm_Load;
    MouseDown += WindowDrag;
    radioContainer.ResumeLayout(false);
    radioContainer.PerformLayout();
    requestContainer.ResumeLayout(false);
    requestContainer.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
}

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button pdcButton;
        private System.Windows.Forms.Button logonButton;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.Panel radioContainer;
        private System.Windows.Forms.RadioButton logonRadioButton;
        private System.Windows.Forms.RadioButton depClxRadioButton;
        private System.Windows.Forms.RadioButton requestRadioButton;
        private System.Windows.Forms.RadioButton reportRadioButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Panel requestContainer;
        private System.Windows.Forms.RadioButton wcwRadioButton;
        private System.Windows.Forms.RadioButton directRadioButton;
        private System.Windows.Forms.RadioButton speedRadioButton;
        private System.Windows.Forms.RadioButton levelRadioButton;
        private System.Windows.Forms.RadioButton ocnClxRadioButton;
        private System.Windows.Forms.TableLayoutPanel messageFormatPanel;
    }
}