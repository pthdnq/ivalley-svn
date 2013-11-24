﻿namespace WhiteChatClient
{
    partial class uiFormChatRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiFormChatRoom));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.uiRichTextBoxHistory = new Khendys.Controls.ExRichTextBox();
            this.uiflowLayoutPanelBuddies = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uiRichTextBoxMsg = new Khendys.Controls.ExRichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uibuttonSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uibuttonTalk = new System.Windows.Forms.Button();
            this.uicheckBoxHandfree = new System.Windows.Forms.CheckBox();
            this.uicheckBoxMute = new System.Windows.Forms.CheckBox();
            this.uitrackBarVolume = new System.Windows.Forms.TrackBar();
            this.uilabelTyping = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.uicomboBoxFont = new System.Windows.Forms.ComboBox();
            this.uicomboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.uibuttonColor = new System.Windows.Forms.Button();
            this.uicheckBoxBold = new System.Windows.Forms.CheckBox();
            this.uicheckBoxItalic = new System.Windows.Forms.CheckBox();
            this.uicheckBoxUnderline = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uibuttonCall = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WaveOut = new AxVCProX.AxvcproWaveOutDeviceX();
            this.WaveIn = new AxVCProX.AxvcproWaveInDeviceX();
            this.ClientX1 = new AxVCProX.AxvcproRTPConfClientX();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uitrackBarVolume)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaveOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaveIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientX1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.111111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 445);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(750, 412);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.66666F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.33333F));
            this.tableLayoutPanel5.Controls.Add(this.uiRichTextBoxHistory, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiflowLayoutPanelBuddies, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(750, 221);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // uiRichTextBoxHistory
            // 
            this.uiRichTextBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiRichTextBoxHistory.HiglightColor = Khendys.Controls.RtfColor.White;
            this.uiRichTextBoxHistory.Location = new System.Drawing.Point(3, 3);
            this.uiRichTextBoxHistory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.uiRichTextBoxHistory.Name = "uiRichTextBoxHistory";
            this.uiRichTextBoxHistory.ReadOnly = true;
            this.uiRichTextBoxHistory.Size = new System.Drawing.Size(554, 218);
            this.uiRichTextBoxHistory.TabIndex = 1;
            this.uiRichTextBoxHistory.Text = global::WhiteChatClient.Properties.Resources.password;
            this.uiRichTextBoxHistory.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // uiflowLayoutPanelBuddies
            // 
            this.uiflowLayoutPanelBuddies.AutoScroll = true;
            this.uiflowLayoutPanelBuddies.BackColor = System.Drawing.Color.White;
            this.uiflowLayoutPanelBuddies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiflowLayoutPanelBuddies.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uiflowLayoutPanelBuddies.Location = new System.Drawing.Point(563, 3);
            this.uiflowLayoutPanelBuddies.Name = "uiflowLayoutPanelBuddies";
            this.uiflowLayoutPanelBuddies.Size = new System.Drawing.Size(184, 215);
            this.uiflowLayoutPanelBuddies.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.uiRichTextBoxMsg, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.14907F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.85093F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(750, 189);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // uiRichTextBoxMsg
            // 
            this.uiRichTextBoxMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiRichTextBoxMsg.HiglightColor = Khendys.Controls.RtfColor.White;
            this.uiRichTextBoxMsg.Location = new System.Drawing.Point(3, 57);
            this.uiRichTextBoxMsg.Name = "uiRichTextBoxMsg";
            this.uiRichTextBoxMsg.Size = new System.Drawing.Size(664, 129);
            this.uiRichTextBoxMsg.TabIndex = 0;
            this.uiRichTextBoxMsg.Text = global::WhiteChatClient.Properties.Resources.password;
            this.uiRichTextBoxMsg.TextColor = Khendys.Controls.RtfColor.Black;
            this.uiRichTextBoxMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiRichTextBoxMsg_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.Controls.Add(this.uibuttonSend, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(673, 57);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(74, 129);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // uibuttonSend
            // 
            this.uibuttonSend.Location = new System.Drawing.Point(3, 28);
            this.uibuttonSend.Name = "uibuttonSend";
            this.uibuttonSend.Size = new System.Drawing.Size(65, 47);
            this.uibuttonSend.TabIndex = 2;
            this.uibuttonSend.Text = "Send";
            this.uibuttonSend.UseVisualStyleBackColor = true;
            this.uibuttonSend.Click += new System.EventHandler(this.uibuttonSend_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.uilabelTyping);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 28);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.uibuttonTalk);
            this.panel4.Controls.Add(this.uicheckBoxHandfree);
            this.panel4.Controls.Add(this.uicheckBoxMute);
            this.panel4.Controls.Add(this.uitrackBarVolume);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 28);
            this.panel4.TabIndex = 1;
            // 
            // uibuttonTalk
            // 
            this.uibuttonTalk.Location = new System.Drawing.Point(89, 4);
            this.uibuttonTalk.Name = "uibuttonTalk";
            this.uibuttonTalk.Size = new System.Drawing.Size(55, 20);
            this.uibuttonTalk.TabIndex = 9;
            this.uibuttonTalk.Text = "Talk";
            this.uibuttonTalk.UseVisualStyleBackColor = true;
            this.uibuttonTalk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uibuttonTalk_MouseDown);
            this.uibuttonTalk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uibuttonTalk_MouseUp);
            // 
            // uicheckBoxHandfree
            // 
            this.uicheckBoxHandfree.AutoSize = true;
            this.uicheckBoxHandfree.Location = new System.Drawing.Point(4, 4);
            this.uicheckBoxHandfree.Name = "uicheckBoxHandfree";
            this.uicheckBoxHandfree.Size = new System.Drawing.Size(79, 17);
            this.uicheckBoxHandfree.TabIndex = 8;
            this.uicheckBoxHandfree.Text = "Hands free";
            this.uicheckBoxHandfree.UseVisualStyleBackColor = true;
            this.uicheckBoxHandfree.CheckedChanged += new System.EventHandler(this.uicheckBoxHandfree_CheckedChanged);
            // 
            // uicheckBoxMute
            // 
            this.uicheckBoxMute.AutoSize = true;
            this.uicheckBoxMute.Location = new System.Drawing.Point(562, 4);
            this.uicheckBoxMute.Name = "uicheckBoxMute";
            this.uicheckBoxMute.Size = new System.Drawing.Size(50, 17);
            this.uicheckBoxMute.TabIndex = 7;
            this.uicheckBoxMute.Text = "Mute";
            this.uicheckBoxMute.UseVisualStyleBackColor = true;
            this.uicheckBoxMute.CheckedChanged += new System.EventHandler(this.uicheckBoxMute_CheckedChanged);
            // 
            // uitrackBarVolume
            // 
            this.uitrackBarVolume.Location = new System.Drawing.Point(627, 1);
            this.uitrackBarVolume.Maximum = 100;
            this.uitrackBarVolume.Name = "uitrackBarVolume";
            this.uitrackBarVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uitrackBarVolume.Size = new System.Drawing.Size(120, 45);
            this.uitrackBarVolume.TabIndex = 6;
            this.uitrackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.uitrackBarVolume.Value = 50;
            this.uitrackBarVolume.Scroll += new System.EventHandler(this.uitrackBarVolume_Scroll);
            // 
            // uilabelTyping
            // 
            this.uilabelTyping.AutoSize = true;
            this.uilabelTyping.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.uilabelTyping.Location = new System.Drawing.Point(7, 4);
            this.uilabelTyping.Name = "uilabelTyping";
            this.uilabelTyping.Size = new System.Drawing.Size(0, 13);
            this.uilabelTyping.TabIndex = 0;
            this.uilabelTyping.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel4.Controls.Add(this.uicomboBoxFont, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.uicomboBoxFontSize, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.uibuttonColor, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.uicheckBoxBold, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.uicheckBoxItalic, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.uicheckBoxUnderline, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 7, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(670, 26);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // uicomboBoxFont
            // 
            this.uicomboBoxFont.FormattingEnabled = true;
            this.uicomboBoxFont.Location = new System.Drawing.Point(219, 3);
            this.uicomboBoxFont.Name = "uicomboBoxFont";
            this.uicomboBoxFont.Size = new System.Drawing.Size(124, 21);
            this.uicomboBoxFont.TabIndex = 4;
            this.uicomboBoxFont.SelectedIndexChanged += new System.EventHandler(this.uicomboBoxFont_SelectedIndexChanged);
            // 
            // uicomboBoxFontSize
            // 
            this.uicomboBoxFontSize.FormattingEnabled = true;
            this.uicomboBoxFontSize.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.uicomboBoxFontSize.Location = new System.Drawing.Point(357, 3);
            this.uicomboBoxFontSize.Name = "uicomboBoxFontSize";
            this.uicomboBoxFontSize.Size = new System.Drawing.Size(38, 21);
            this.uicomboBoxFontSize.TabIndex = 5;
            this.uicomboBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.uicomboBoxFontSize_SelectedIndexChanged);
            // 
            // uibuttonColor
            // 
            this.uibuttonColor.Location = new System.Drawing.Point(140, 3);
            this.uibuttonColor.Name = "uibuttonColor";
            this.uibuttonColor.Size = new System.Drawing.Size(45, 20);
            this.uibuttonColor.TabIndex = 6;
            this.uibuttonColor.Text = "Color";
            this.uibuttonColor.UseVisualStyleBackColor = true;
            this.uibuttonColor.Click += new System.EventHandler(this.uibuttonColor_Click);
            // 
            // uicheckBoxBold
            // 
            this.uicheckBoxBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.uicheckBoxBold.AutoSize = true;
            this.uicheckBoxBold.FlatAppearance.BorderSize = 0;
            this.uicheckBoxBold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uicheckBoxBold.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.uicheckBoxBold.Location = new System.Drawing.Point(20, 3);
            this.uicheckBoxBold.Name = "uicheckBoxBold";
            this.uicheckBoxBold.Size = new System.Drawing.Size(24, 20);
            this.uicheckBoxBold.TabIndex = 7;
            this.uicheckBoxBold.Text = "B";
            this.uicheckBoxBold.UseVisualStyleBackColor = true;
            this.uicheckBoxBold.CheckedChanged += new System.EventHandler(this.uicheckBoxBold_CheckedChanged);
            // 
            // uicheckBoxItalic
            // 
            this.uicheckBoxItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.uicheckBoxItalic.AutoSize = true;
            this.uicheckBoxItalic.FlatAppearance.BorderSize = 0;
            this.uicheckBoxItalic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uicheckBoxItalic.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.uicheckBoxItalic.Location = new System.Drawing.Point(59, 3);
            this.uicheckBoxItalic.Name = "uicheckBoxItalic";
            this.uicheckBoxItalic.Size = new System.Drawing.Size(22, 20);
            this.uicheckBoxItalic.TabIndex = 8;
            this.uicheckBoxItalic.Text = "I";
            this.uicheckBoxItalic.UseVisualStyleBackColor = true;
            this.uicheckBoxItalic.CheckedChanged += new System.EventHandler(this.uicheckBoxItalic_CheckedChanged);
            // 
            // uicheckBoxUnderline
            // 
            this.uicheckBoxUnderline.Appearance = System.Windows.Forms.Appearance.Button;
            this.uicheckBoxUnderline.AutoSize = true;
            this.uicheckBoxUnderline.FlatAppearance.BorderSize = 0;
            this.uicheckBoxUnderline.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ScrollBar;
            this.uicheckBoxUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uicheckBoxUnderline.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.uicheckBoxUnderline.Location = new System.Drawing.Point(100, 3);
            this.uicheckBoxUnderline.Name = "uicheckBoxUnderline";
            this.uicheckBoxUnderline.Size = new System.Drawing.Size(25, 20);
            this.uicheckBoxUnderline.TabIndex = 9;
            this.uicheckBoxUnderline.Text = "U";
            this.uicheckBoxUnderline.UseVisualStyleBackColor = true;
            this.uicheckBoxUnderline.CheckedChanged += new System.EventHandler(this.uicheckBoxUnderline_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uibuttonCall);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(406, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 26);
            this.panel3.TabIndex = 10;
            // 
            // uibuttonCall
            // 
            this.uibuttonCall.Location = new System.Drawing.Point(170, 2);
            this.uibuttonCall.Name = "uibuttonCall";
            this.uibuttonCall.Size = new System.Drawing.Size(85, 20);
            this.uibuttonCall.TabIndex = 4;
            this.uibuttonCall.Text = "Call";
            this.uibuttonCall.UseVisualStyleBackColor = true;
            this.uibuttonCall.Click += new System.EventHandler(this.uibuttonCall_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WaveOut);
            this.panel2.Controls.Add(this.WaveIn);
            this.panel2.Controls.Add(this.ClientX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 21);
            this.panel2.TabIndex = 1;
            // 
            // WaveOut
            // 
            this.WaveOut.Enabled = true;
            this.WaveOut.Location = new System.Drawing.Point(204, -5);
            this.WaveOut.Name = "WaveOut";
            this.WaveOut.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WaveOut.OcxState")));
            this.WaveOut.Size = new System.Drawing.Size(75, 23);
            this.WaveOut.TabIndex = 2;
            this.WaveOut.Visible = false;
            // 
            // WaveIn
            // 
            this.WaveIn.Enabled = true;
            this.WaveIn.Location = new System.Drawing.Point(110, -2);
            this.WaveIn.Name = "WaveIn";
            this.WaveIn.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WaveIn.OcxState")));
            this.WaveIn.Size = new System.Drawing.Size(75, 23);
            this.WaveIn.TabIndex = 1;
            this.WaveIn.Visible = false;
            // 
            // ClientX1
            // 
            this.ClientX1.Enabled = true;
            this.ClientX1.Location = new System.Drawing.Point(10, -5);
            this.ClientX1.Name = "ClientX1";
            this.ClientX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ClientX1.OcxState")));
            this.ClientX1.Size = new System.Drawing.Size(75, 23);
            this.ClientX1.TabIndex = 0;
            this.ClientX1.Visible = false;
            // 
            // uiFormChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uiFormChatRoom";
            this.Text = "uiFormChatRoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.uiFormChatRoom_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uitrackBarVolume)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WaveOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaveIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Khendys.Controls.ExRichTextBox uiRichTextBoxMsg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button uibuttonSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uilabelTyping;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox uicomboBoxFont;
        private System.Windows.Forms.ComboBox uicomboBoxFontSize;
        private System.Windows.Forms.Button uibuttonColor;
        private System.Windows.Forms.CheckBox uicheckBoxBold;
        private System.Windows.Forms.CheckBox uicheckBoxItalic;
        private System.Windows.Forms.CheckBox uicheckBoxUnderline;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Khendys.Controls.ExRichTextBox uiRichTextBoxHistory;
        private System.Windows.Forms.FlowLayoutPanel uiflowLayoutPanelBuddies;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel2;
        private AxVCProX.AxvcproWaveOutDeviceX WaveOut;
        private AxVCProX.AxvcproWaveInDeviceX WaveIn;
        private AxVCProX.AxvcproRTPConfClientX ClientX1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button uibuttonCall;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar uitrackBarVolume;
        private System.Windows.Forms.CheckBox uicheckBoxMute;
        private System.Windows.Forms.CheckBox uicheckBoxHandfree;
        private System.Windows.Forms.Button uibuttonTalk;
    }
}