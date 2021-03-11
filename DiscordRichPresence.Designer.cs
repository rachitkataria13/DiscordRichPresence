namespace Discord_Rich_Presence
{
    partial class DiscordRichPresence
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordRichPresence));
            this.txtApplicationId = new System.Windows.Forms.Label();
            this.applicationId = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.detail = new System.Windows.Forms.TextBox();
            this.largeImage = new System.Windows.Forms.ComboBox();
            this.smallImage = new System.Windows.Forms.ComboBox();
            this.largeImageText = new System.Windows.Forms.TextBox();
            this.smallImageText = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.Label();
            this.txtLargeImage = new System.Windows.Forms.Label();
            this.txtSmallImage = new System.Windows.Forms.Label();
            this.txtLargeImageText = new System.Windows.Forms.Label();
            this.txtSmallImageText = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.taskbarStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAppName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.endTsLabel = new System.Windows.Forms.Label();
            this.cbTimeElapsed = new System.Windows.Forms.CheckBox();
            this.cbTimeLeft = new System.Windows.Forms.CheckBox();
            this.endTimeminutes = new System.Windows.Forms.TextBox();
            this.cbParty = new System.Windows.Forms.CheckBox();
            this.partyCurrentLabel = new System.Windows.Forms.Label();
            this.partyMaxLabel = new System.Windows.Forms.Label();
            this.partyCurrent = new System.Windows.Forms.NumericUpDown();
            this.partyMax = new System.Windows.Forms.NumericUpDown();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.groupTime = new System.Windows.Forms.GroupBox();
            this.groupParty = new System.Windows.Forms.GroupBox();
            this.groupButtons = new System.Windows.Forms.GroupBox();
            this.cbButtons = new System.Windows.Forms.CheckBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.taskbarStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMax)).BeginInit();
            this.groupMain.SuspendLayout();
            this.groupTime.SuspendLayout();
            this.groupParty.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApplicationId
            // 
            this.txtApplicationId.AutoSize = true;
            this.txtApplicationId.Location = new System.Drawing.Point(17, 30);
            this.txtApplicationId.Name = "txtApplicationId";
            this.txtApplicationId.Size = new System.Drawing.Size(79, 13);
            this.txtApplicationId.TabIndex = 0;
            this.txtApplicationId.Text = "Application ID: ";
            // 
            // applicationId
            // 
            this.applicationId.Location = new System.Drawing.Point(102, 27);
            this.applicationId.Name = "applicationId";
            this.applicationId.Size = new System.Drawing.Size(232, 20);
            this.applicationId.TabIndex = 0;
            this.applicationId.TextChanged += new System.EventHandler(this.applicationId_TextChanged);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(102, 69);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(232, 20);
            this.status.TabIndex = 1;
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(102, 116);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(232, 20);
            this.detail.TabIndex = 2;
            // 
            // largeImage
            // 
            this.largeImage.FormattingEnabled = true;
            this.largeImage.Location = new System.Drawing.Point(102, 163);
            this.largeImage.Name = "largeImage";
            this.largeImage.Size = new System.Drawing.Size(232, 21);
            this.largeImage.TabIndex = 3;
            // 
            // smallImage
            // 
            this.smallImage.FormattingEnabled = true;
            this.smallImage.Location = new System.Drawing.Point(102, 210);
            this.smallImage.Name = "smallImage";
            this.smallImage.Size = new System.Drawing.Size(232, 21);
            this.smallImage.TabIndex = 4;
            // 
            // largeImageText
            // 
            this.largeImageText.Location = new System.Drawing.Point(102, 258);
            this.largeImageText.Name = "largeImageText";
            this.largeImageText.Size = new System.Drawing.Size(232, 20);
            this.largeImageText.TabIndex = 5;
            // 
            // smallImageText
            // 
            this.smallImageText.Location = new System.Drawing.Point(102, 303);
            this.smallImageText.Name = "smallImageText";
            this.smallImageText.Size = new System.Drawing.Size(232, 20);
            this.smallImageText.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(20, 72);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(43, 13);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.Text = "Status: ";
            // 
            // txtDetail
            // 
            this.txtDetail.AutoSize = true;
            this.txtDetail.Location = new System.Drawing.Point(20, 119);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(40, 13);
            this.txtDetail.TabIndex = 10;
            this.txtDetail.Text = "Detail: ";
            // 
            // txtLargeImage
            // 
            this.txtLargeImage.AutoSize = true;
            this.txtLargeImage.Location = new System.Drawing.Point(20, 166);
            this.txtLargeImage.Name = "txtLargeImage";
            this.txtLargeImage.Size = new System.Drawing.Size(72, 13);
            this.txtLargeImage.TabIndex = 11;
            this.txtLargeImage.Text = "Large Image: ";
            // 
            // txtSmallImage
            // 
            this.txtSmallImage.AutoSize = true;
            this.txtSmallImage.Location = new System.Drawing.Point(20, 213);
            this.txtSmallImage.Name = "txtSmallImage";
            this.txtSmallImage.Size = new System.Drawing.Size(70, 13);
            this.txtSmallImage.TabIndex = 12;
            this.txtSmallImage.Text = "Small Image: ";
            // 
            // txtLargeImageText
            // 
            this.txtLargeImageText.AutoSize = true;
            this.txtLargeImageText.Location = new System.Drawing.Point(9, 261);
            this.txtLargeImageText.Name = "txtLargeImageText";
            this.txtLargeImageText.Size = new System.Drawing.Size(87, 13);
            this.txtLargeImageText.TabIndex = 13;
            this.txtLargeImageText.Text = "Large Image Tip:";
            // 
            // txtSmallImageText
            // 
            this.txtSmallImageText.AutoSize = true;
            this.txtSmallImageText.Location = new System.Drawing.Point(8, 306);
            this.txtSmallImageText.Name = "txtSmallImageText";
            this.txtSmallImageText.Size = new System.Drawing.Size(88, 13);
            this.txtSmallImageText.TabIndex = 14;
            this.txtSmallImageText.Text = "Small Image Tip: ";
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(180, 370);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(360, 370);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // notificationIcon
            // 
            this.notificationIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificationIcon.BalloonTipText = "Application minimized.";
            this.notificationIcon.BalloonTipTitle = "Notification";
            this.notificationIcon.ContextMenuStrip = this.taskbarStrip;
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Text = "Rich Presence - Discord";
            this.notificationIcon.Visible = true;
            // 
            // taskbarStrip
            // 
            this.taskbarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.taskbarStrip.Name = "taskbarStrip";
            this.taskbarStrip.Size = new System.Drawing.Size(99, 76);
            this.taskbarStrip.Text = "Taskbar Menu";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripAppName
            // 
            this.toolStripAppName.Name = "toolStripAppName";
            this.toolStripAppName.Size = new System.Drawing.Size(500, 17);
            this.toolStripAppName.Spring = true;
            this.toolStripAppName.Text = "Discord Rich Presence";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAppName,
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatus.Text = "Status: Stopped";
            // 
            // endTsLabel
            // 
            this.endTsLabel.AutoSize = true;
            this.endTsLabel.Location = new System.Drawing.Point(6, 74);
            this.endTsLabel.Name = "endTsLabel";
            this.endTsLabel.Size = new System.Drawing.Size(112, 13);
            this.endTsLabel.TabIndex = 20;
            this.endTsLabel.Text = "End Time (in Minutes):";
            // 
            // cbTimeElapsed
            // 
            this.cbTimeElapsed.AutoSize = true;
            this.cbTimeElapsed.Location = new System.Drawing.Point(9, 27);
            this.cbTimeElapsed.Name = "cbTimeElapsed";
            this.cbTimeElapsed.Size = new System.Drawing.Size(126, 17);
            this.cbTimeElapsed.TabIndex = 7;
            this.cbTimeElapsed.Text = "Enable Time Elapsed";
            this.cbTimeElapsed.UseVisualStyleBackColor = true;
            this.cbTimeElapsed.CheckedChanged += new System.EventHandler(this.cbTimeElapsed_CheckedChanged);
            // 
            // cbTimeLeft
            // 
            this.cbTimeLeft.AutoSize = true;
            this.cbTimeLeft.Location = new System.Drawing.Point(9, 50);
            this.cbTimeLeft.Name = "cbTimeLeft";
            this.cbTimeLeft.Size = new System.Drawing.Size(106, 17);
            this.cbTimeLeft.TabIndex = 8;
            this.cbTimeLeft.Text = "Enable Time Left";
            this.cbTimeLeft.UseVisualStyleBackColor = true;
            this.cbTimeLeft.CheckedChanged += new System.EventHandler(this.cbTimeLeft_CheckedChanged);
            // 
            // endTimeminutes
            // 
            this.endTimeminutes.Enabled = false;
            this.endTimeminutes.Location = new System.Drawing.Point(124, 70);
            this.endTimeminutes.Name = "endTimeminutes";
            this.endTimeminutes.Size = new System.Drawing.Size(98, 20);
            this.endTimeminutes.TabIndex = 9;
            this.endTimeminutes.TextChanged += new System.EventHandler(this.endTimeminutes_TextChanged);
            // 
            // cbParty
            // 
            this.cbParty.AutoSize = true;
            this.cbParty.Location = new System.Drawing.Point(73, 19);
            this.cbParty.Name = "cbParty";
            this.cbParty.Size = new System.Drawing.Size(86, 17);
            this.cbParty.TabIndex = 10;
            this.cbParty.Text = "Enable Party";
            this.cbParty.UseVisualStyleBackColor = true;
            this.cbParty.CheckedChanged += new System.EventHandler(this.cbParty_CheckedChanged);
            // 
            // partyCurrentLabel
            // 
            this.partyCurrentLabel.AutoSize = true;
            this.partyCurrentLabel.Location = new System.Drawing.Point(20, 44);
            this.partyCurrentLabel.Name = "partyCurrentLabel";
            this.partyCurrentLabel.Size = new System.Drawing.Size(47, 13);
            this.partyCurrentLabel.TabIndex = 24;
            this.partyCurrentLabel.Text = "Players: ";
            // 
            // partyMaxLabel
            // 
            this.partyMaxLabel.AutoSize = true;
            this.partyMaxLabel.Location = new System.Drawing.Point(20, 77);
            this.partyMaxLabel.Name = "partyMaxLabel";
            this.partyMaxLabel.Size = new System.Drawing.Size(33, 13);
            this.partyMaxLabel.TabIndex = 25;
            this.partyMaxLabel.Text = "Max: ";
            // 
            // partyCurrent
            // 
            this.partyCurrent.Enabled = false;
            this.partyCurrent.Location = new System.Drawing.Point(73, 42);
            this.partyCurrent.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.partyCurrent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyCurrent.Name = "partyCurrent";
            this.partyCurrent.Size = new System.Drawing.Size(128, 20);
            this.partyCurrent.TabIndex = 11;
            this.partyCurrent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyCurrent.ValueChanged += new System.EventHandler(this.partyCurrent_ValueChanged);
            // 
            // partyMax
            // 
            this.partyMax.Enabled = false;
            this.partyMax.Location = new System.Drawing.Point(73, 75);
            this.partyMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.partyMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyMax.Name = "partyMax";
            this.partyMax.Size = new System.Drawing.Size(128, 20);
            this.partyMax.TabIndex = 12;
            this.partyMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyMax.ValueChanged += new System.EventHandler(this.partyMax_ValueChanged);
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.applicationId);
            this.groupMain.Controls.Add(this.txtApplicationId);
            this.groupMain.Controls.Add(this.status);
            this.groupMain.Controls.Add(this.detail);
            this.groupMain.Controls.Add(this.largeImage);
            this.groupMain.Controls.Add(this.smallImage);
            this.groupMain.Controls.Add(this.largeImageText);
            this.groupMain.Controls.Add(this.smallImageText);
            this.groupMain.Controls.Add(this.txtStatus);
            this.groupMain.Controls.Add(this.txtDetail);
            this.groupMain.Controls.Add(this.txtLargeImage);
            this.groupMain.Controls.Add(this.txtSmallImage);
            this.groupMain.Controls.Add(this.txtLargeImageText);
            this.groupMain.Controls.Add(this.txtSmallImageText);
            this.groupMain.Location = new System.Drawing.Point(12, 2);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(347, 341);
            this.groupMain.TabIndex = 26;
            this.groupMain.TabStop = false;
            this.groupMain.Text = "Main Section";
            // 
            // groupTime
            // 
            this.groupTime.Controls.Add(this.endTsLabel);
            this.groupTime.Controls.Add(this.endTimeminutes);
            this.groupTime.Controls.Add(this.cbTimeElapsed);
            this.groupTime.Controls.Add(this.cbTimeLeft);
            this.groupTime.Location = new System.Drawing.Point(364, 2);
            this.groupTime.Name = "groupTime";
            this.groupTime.Size = new System.Drawing.Size(228, 97);
            this.groupTime.TabIndex = 27;
            this.groupTime.TabStop = false;
            this.groupTime.Text = "Time Settings";
            // 
            // groupParty
            // 
            this.groupParty.Controls.Add(this.cbParty);
            this.groupParty.Controls.Add(this.partyCurrent);
            this.groupParty.Controls.Add(this.partyCurrentLabel);
            this.groupParty.Controls.Add(this.partyMax);
            this.groupParty.Controls.Add(this.partyMaxLabel);
            this.groupParty.Location = new System.Drawing.Point(365, 105);
            this.groupParty.Name = "groupParty";
            this.groupParty.Size = new System.Drawing.Size(227, 104);
            this.groupParty.TabIndex = 28;
            this.groupParty.TabStop = false;
            this.groupParty.Text = "Party Settings";
            // 
            // groupButtons
            // 
            this.groupButtons.Controls.Add(this.cbButtons);
            this.groupButtons.Controls.Add(this.txtUrl);
            this.groupButtons.Controls.Add(this.txtLabel);
            this.groupButtons.Controls.Add(this.lblUrl);
            this.groupButtons.Controls.Add(this.lblLabel);
            this.groupButtons.Location = new System.Drawing.Point(367, 213);
            this.groupButtons.Name = "groupButtons";
            this.groupButtons.Size = new System.Drawing.Size(225, 129);
            this.groupButtons.TabIndex = 29;
            this.groupButtons.TabStop = false;
            this.groupButtons.Text = "Button Settings";
            // 
            // cbButtons
            // 
            this.cbButtons.AutoSize = true;
            this.cbButtons.Location = new System.Drawing.Point(71, 19);
            this.cbButtons.Name = "cbButtons";
            this.cbButtons.Size = new System.Drawing.Size(93, 17);
            this.cbButtons.TabIndex = 4;
            this.cbButtons.Text = "Enable Button";
            this.cbButtons.UseVisualStyleBackColor = true;
            this.cbButtons.CheckedChanged += new System.EventHandler(this.cbButtons_CheckedChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Enabled = false;
            this.txtUrl.Location = new System.Drawing.Point(71, 80);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(128, 20);
            this.txtUrl.TabIndex = 3;
            // 
            // txtLabel
            // 
            this.txtLabel.Enabled = false;
            this.txtLabel.Location = new System.Drawing.Point(71, 47);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(128, 20);
            this.txtLabel.TabIndex = 2;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(17, 83);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL:";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(17, 47);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(33, 13);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Label";
            // 
            // DiscordRichPresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 441);
            this.Controls.Add(this.groupButtons);
            this.Controls.Add(this.groupParty);
            this.Controls.Add(this.groupTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 480);
            this.MinimumSize = new System.Drawing.Size(620, 480);
            this.Name = "DiscordRichPresence";
            this.Text = "Discord Rich Presence";
            this.Load += new System.EventHandler(this.DRP_Load);
            this.taskbarStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMax)).EndInit();
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            this.groupTime.ResumeLayout(false);
            this.groupTime.PerformLayout();
            this.groupParty.ResumeLayout(false);
            this.groupParty.PerformLayout();
            this.groupButtons.ResumeLayout(false);
            this.groupButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtApplicationId;
        private System.Windows.Forms.TextBox applicationId;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.ComboBox largeImage;
        private System.Windows.Forms.ComboBox smallImage;
        private System.Windows.Forms.TextBox largeImageText;
        private System.Windows.Forms.TextBox smallImageText;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtDetail;
        private System.Windows.Forms.Label txtLargeImage;
        private System.Windows.Forms.Label txtSmallImage;
        private System.Windows.Forms.Label txtLargeImageText;
        private System.Windows.Forms.Label txtSmallImageText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NotifyIcon notificationIcon;
        private System.Windows.Forms.ContextMenuStrip taskbarStrip;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAppName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.Label endTsLabel;
        private System.Windows.Forms.CheckBox cbTimeElapsed;
        private System.Windows.Forms.CheckBox cbTimeLeft;
        private System.Windows.Forms.TextBox endTimeminutes;
        private System.Windows.Forms.CheckBox cbParty;
        private System.Windows.Forms.Label partyCurrentLabel;
        private System.Windows.Forms.Label partyMaxLabel;
        private System.Windows.Forms.NumericUpDown partyCurrent;
        private System.Windows.Forms.NumericUpDown partyMax;
        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.GroupBox groupTime;
        private System.Windows.Forms.GroupBox groupParty;
        private System.Windows.Forms.GroupBox groupButtons;
        private System.Windows.Forms.CheckBox cbButtons;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblLabel;
    }
}

