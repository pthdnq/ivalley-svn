﻿namespace WhiteChatClient
{
    partial class uiFormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiFormMain));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uimenuStripMain = new System.Windows.Forms.MenuStrip();
            this.messengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uipanelinfo = new System.Windows.Forms.Panel();
            this.uilabelBuddyName = new System.Windows.Forms.Label();
            this.uicomboBoxStatus = new System.Windows.Forms.ComboBox();
            this.uipictureBoxBuddyProfile = new System.Windows.Forms.PictureBox();
            this.uipanelSearch = new System.Windows.Forms.Panel();
            this.uibuttonAdd = new System.Windows.Forms.Button();
            this.uitextBoxSearch = new System.Windows.Forms.TextBox();
            this.uipanelLogin = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uicheckBoxInvisible = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uibuttonSignin = new System.Windows.Forms.Button();
            this.uicheckBoxRemember = new System.Windows.Forms.CheckBox();
            this.uitextBoxPassword = new System.Windows.Forms.TextBox();
            this.uitextBoxUsername = new System.Windows.Forms.TextBox();
            this.uipanelLoading = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uilabelLogging = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiflowLayoutPanelBuddies = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.uimenuStripMain.SuspendLayout();
            this.uipanelinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipictureBoxBuddyProfile)).BeginInit();
            this.uipanelSearch.SuspendLayout();
            this.uipanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.uipanelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.uimenuStripMain);
            this.flowLayoutPanel1.Controls.Add(this.uipanelinfo);
            this.flowLayoutPanel1.Controls.Add(this.uipanelSearch);
            this.flowLayoutPanel1.Controls.Add(this.uipanelLogin);
            this.flowLayoutPanel1.Controls.Add(this.uipanelLoading);
            this.flowLayoutPanel1.Controls.Add(this.uiflowLayoutPanelBuddies);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 572);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // uimenuStripMain
            // 
            this.uimenuStripMain.AutoSize = false;
            this.uimenuStripMain.BackColor = System.Drawing.Color.SandyBrown;
            this.uimenuStripMain.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.uimenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messengerToolStripMenuItem});
            this.uimenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.uimenuStripMain.Name = "uimenuStripMain";
            this.uimenuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.uimenuStripMain.Size = new System.Drawing.Size(290, 24);
            this.uimenuStripMain.TabIndex = 7;
            this.uimenuStripMain.Text = "menuStrip1";
            // 
            // messengerToolStripMenuItem
            // 
            this.messengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatRoomsToolStripMenuItem,
            this.addNewContactToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.messengerToolStripMenuItem.Name = "messengerToolStripMenuItem";
            this.messengerToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.messengerToolStripMenuItem.Text = "Messenger";
            // 
            // chatRoomsToolStripMenuItem
            // 
            this.chatRoomsToolStripMenuItem.Name = "chatRoomsToolStripMenuItem";
            this.chatRoomsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.chatRoomsToolStripMenuItem.Text = "Chat rooms";
            this.chatRoomsToolStripMenuItem.Click += new System.EventHandler(this.chatRoomsToolStripMenuItem_Click);
            // 
            // addNewContactToolStripMenuItem
            // 
            this.addNewContactToolStripMenuItem.Name = "addNewContactToolStripMenuItem";
            this.addNewContactToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addNewContactToolStripMenuItem.Text = "Add a contact";
            this.addNewContactToolStripMenuItem.Click += new System.EventHandler(this.addNewContactToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // uipanelinfo
            // 
            this.uipanelinfo.BackColor = System.Drawing.Color.Transparent;
            this.uipanelinfo.Controls.Add(this.uilabelBuddyName);
            this.uipanelinfo.Controls.Add(this.uicomboBoxStatus);
            this.uipanelinfo.Controls.Add(this.uipictureBoxBuddyProfile);
            this.uipanelinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.uipanelinfo.Location = new System.Drawing.Point(0, 24);
            this.uipanelinfo.Margin = new System.Windows.Forms.Padding(0);
            this.uipanelinfo.Name = "uipanelinfo";
            this.uipanelinfo.Size = new System.Drawing.Size(290, 49);
            this.uipanelinfo.TabIndex = 9;
            // 
            // uilabelBuddyName
            // 
            this.uilabelBuddyName.AutoSize = true;
            this.uilabelBuddyName.BackColor = System.Drawing.Color.Transparent;
            this.uilabelBuddyName.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.uilabelBuddyName.Location = new System.Drawing.Point(68, 3);
            this.uilabelBuddyName.Name = "uilabelBuddyName";
            this.uilabelBuddyName.Size = new System.Drawing.Size(79, 18);
            this.uilabelBuddyName.TabIndex = 2;
            this.uilabelBuddyName.Text = "wezamena";
            this.uilabelBuddyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uicomboBoxStatus
            // 
            this.uicomboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uicomboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uicomboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uicomboBoxStatus.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.uicomboBoxStatus.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.uicomboBoxStatus.FormattingEnabled = true;
            this.uicomboBoxStatus.Items.AddRange(new object[] {
            "Online",
            "Away",
            "Busy",
            "Offline"});
            this.uicomboBoxStatus.Location = new System.Drawing.Point(65, 23);
            this.uicomboBoxStatus.Margin = new System.Windows.Forms.Padding(0);
            this.uicomboBoxStatus.Name = "uicomboBoxStatus";
            this.uicomboBoxStatus.Size = new System.Drawing.Size(106, 26);
            this.uicomboBoxStatus.TabIndex = 1;
            this.uicomboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.uicomboBoxStatus_SelectedIndexChanged);
            // 
            // uipictureBoxBuddyProfile
            // 
            this.uipictureBoxBuddyProfile.Location = new System.Drawing.Point(16, 7);
            this.uipictureBoxBuddyProfile.Name = "uipictureBoxBuddyProfile";
            this.uipictureBoxBuddyProfile.Size = new System.Drawing.Size(35, 35);
            this.uipictureBoxBuddyProfile.TabIndex = 0;
            this.uipictureBoxBuddyProfile.TabStop = false;
            // 
            // uipanelSearch
            // 
            this.uipanelSearch.BackColor = System.Drawing.Color.Transparent;
            this.uipanelSearch.Controls.Add(this.uibuttonAdd);
            this.uipanelSearch.Controls.Add(this.uitextBoxSearch);
            this.uipanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uipanelSearch.Location = new System.Drawing.Point(0, 73);
            this.uipanelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.uipanelSearch.Name = "uipanelSearch";
            this.uipanelSearch.Size = new System.Drawing.Size(290, 30);
            this.uipanelSearch.TabIndex = 8;
            // 
            // uibuttonAdd
            // 
            this.uibuttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.uibuttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uibuttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibuttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(147)))), ((int)(((byte)(32)))));
            this.uibuttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(18)))));
            this.uibuttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(149)))));
            this.uibuttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uibuttonAdd.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.uibuttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(147)))), ((int)(((byte)(32)))));
            this.uibuttonAdd.Location = new System.Drawing.Point(10, 3);
            this.uibuttonAdd.Name = "uibuttonAdd";
            this.uibuttonAdd.Size = new System.Drawing.Size(49, 23);
            this.uibuttonAdd.TabIndex = 1;
            this.uibuttonAdd.Text = "Add";
            this.uibuttonAdd.UseVisualStyleBackColor = false;
            this.uibuttonAdd.Click += new System.EventHandler(this.uibuttonAdd_Click);
            // 
            // uitextBoxSearch
            // 
            this.uitextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.uitextBoxSearch.Location = new System.Drawing.Point(65, 4);
            this.uitextBoxSearch.Name = "uitextBoxSearch";
            this.uitextBoxSearch.Size = new System.Drawing.Size(204, 20);
            this.uitextBoxSearch.TabIndex = 0;
            this.uitextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uitextBoxSearch_KeyDown);
            // 
            // uipanelLogin
            // 
            this.uipanelLogin.BackColor = System.Drawing.Color.Transparent;
            this.uipanelLogin.Controls.Add(this.pictureBox2);
            this.uipanelLogin.Controls.Add(this.uicheckBoxInvisible);
            this.uipanelLogin.Controls.Add(this.label2);
            this.uipanelLogin.Controls.Add(this.label1);
            this.uipanelLogin.Controls.Add(this.uibuttonSignin);
            this.uipanelLogin.Controls.Add(this.uicheckBoxRemember);
            this.uipanelLogin.Controls.Add(this.uitextBoxPassword);
            this.uipanelLogin.Controls.Add(this.uitextBoxUsername);
            this.uipanelLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uipanelLogin.Location = new System.Drawing.Point(0, 103);
            this.uipanelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.uipanelLogin.Name = "uipanelLogin";
            this.uipanelLogin.Size = new System.Drawing.Size(290, 600);
            this.uipanelLogin.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "images/Chatnall_Icons_7.png";
            this.pictureBox2.Location = new System.Drawing.Point(62, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 126);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // uicheckBoxInvisible
            // 
            this.uicheckBoxInvisible.AutoSize = true;
            this.uicheckBoxInvisible.BackColor = System.Drawing.Color.Transparent;
            this.uicheckBoxInvisible.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.uicheckBoxInvisible.Location = new System.Drawing.Point(29, 311);
            this.uicheckBoxInvisible.Name = "uicheckBoxInvisible";
            this.uicheckBoxInvisible.Size = new System.Drawing.Size(251, 25);
            this.uicheckBoxInvisible.TabIndex = 6;
            this.uicheckBoxInvisible.Text = "Sign in as invisible to everyone";
            this.uicheckBoxInvisible.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yahoo ID:";
            // 
            // uibuttonSignin
            // 
            this.uibuttonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.uibuttonSignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uibuttonSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibuttonSignin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(147)))), ((int)(((byte)(32)))));
            this.uibuttonSignin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(18)))));
            this.uibuttonSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(149)))));
            this.uibuttonSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uibuttonSignin.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold);
            this.uibuttonSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(147)))), ((int)(((byte)(32)))));
            this.uibuttonSignin.Location = new System.Drawing.Point(101, 355);
            this.uibuttonSignin.Name = "uibuttonSignin";
            this.uibuttonSignin.Size = new System.Drawing.Size(97, 37);
            this.uibuttonSignin.TabIndex = 3;
            this.uibuttonSignin.Text = "Sign in";
            this.uibuttonSignin.UseVisualStyleBackColor = false;
            this.uibuttonSignin.Click += new System.EventHandler(this.uibuttonSignin_Click);
            // 
            // uicheckBoxRemember
            // 
            this.uicheckBoxRemember.AutoSize = true;
            this.uicheckBoxRemember.BackColor = System.Drawing.Color.Transparent;
            this.uicheckBoxRemember.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.uicheckBoxRemember.Location = new System.Drawing.Point(29, 288);
            this.uicheckBoxRemember.Name = "uicheckBoxRemember";
            this.uicheckBoxRemember.Size = new System.Drawing.Size(247, 25);
            this.uicheckBoxRemember.TabIndex = 2;
            this.uicheckBoxRemember.Text = "Remember my ID && password";
            this.uicheckBoxRemember.UseVisualStyleBackColor = false;
            // 
            // uitextBoxPassword
            // 
            this.uitextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.uitextBoxPassword.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.uitextBoxPassword.Location = new System.Drawing.Point(29, 244);
            this.uitextBoxPassword.Name = "uitextBoxPassword";
            this.uitextBoxPassword.PasswordChar = '*';
            this.uitextBoxPassword.Size = new System.Drawing.Size(160, 24);
            this.uitextBoxPassword.TabIndex = 1;
            this.uitextBoxPassword.Text = "A12345678";
            // 
            // uitextBoxUsername
            // 
            this.uitextBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.uitextBoxUsername.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.uitextBoxUsername.Location = new System.Drawing.Point(29, 192);
            this.uitextBoxUsername.Name = "uitextBoxUsername";
            this.uitextBoxUsername.Size = new System.Drawing.Size(160, 24);
            this.uitextBoxUsername.TabIndex = 0;
            this.uitextBoxUsername.Text = "c_cuser";
            // 
            // uipanelLoading
            // 
            this.uipanelLoading.BackColor = System.Drawing.Color.Transparent;
            this.uipanelLoading.Controls.Add(this.pictureBox3);
            this.uipanelLoading.Controls.Add(this.uilabelLogging);
            this.uipanelLoading.Controls.Add(this.pictureBox1);
            this.uipanelLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uipanelLoading.Location = new System.Drawing.Point(3, 706);
            this.uipanelLoading.Name = "uipanelLoading";
            this.uipanelLoading.Size = new System.Drawing.Size(290, 600);
            this.uipanelLoading.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "images/Chatnall_Icons_7.png";
            this.pictureBox3.Location = new System.Drawing.Point(67, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 126);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // uilabelLogging
            // 
            this.uilabelLogging.AutoSize = true;
            this.uilabelLogging.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.uilabelLogging.Location = new System.Drawing.Point(82, 344);
            this.uilabelLogging.Name = "uilabelLogging";
            this.uilabelLogging.Size = new System.Drawing.Size(0, 19);
            this.uilabelLogging.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ImageLocation = "Images/ajax-loader.gif";
            this.pictureBox1.Location = new System.Drawing.Point(81, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // uiflowLayoutPanelBuddies
            // 
            this.uiflowLayoutPanelBuddies.AutoScroll = true;
            this.uiflowLayoutPanelBuddies.BackColor = System.Drawing.Color.Transparent;
            this.uiflowLayoutPanelBuddies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiflowLayoutPanelBuddies.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uiflowLayoutPanelBuddies.Location = new System.Drawing.Point(0, 1309);
            this.uiflowLayoutPanelBuddies.Margin = new System.Windows.Forms.Padding(0);
            this.uiflowLayoutPanelBuddies.Name = "uiflowLayoutPanelBuddies";
            this.uiflowLayoutPanelBuddies.Size = new System.Drawing.Size(290, 485);
            this.uiflowLayoutPanelBuddies.TabIndex = 2;
            this.uiflowLayoutPanelBuddies.WrapContents = false;
            // 
            // uiFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhiteChatClient.Properties.Resources.sky_blue_background_hd_desktop_wallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 568);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.uimenuStripMain;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 600);
            this.Name = "uiFormMain";
            this.Text = "ChatNAll";
            this.Load += new System.EventHandler(this.uiFormMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.uimenuStripMain.ResumeLayout(false);
            this.uimenuStripMain.PerformLayout();
            this.uipanelinfo.ResumeLayout(false);
            this.uipanelinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipictureBoxBuddyProfile)).EndInit();
            this.uipanelSearch.ResumeLayout(false);
            this.uipanelSearch.PerformLayout();
            this.uipanelLogin.ResumeLayout(false);
            this.uipanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.uipanelLoading.ResumeLayout(false);
            this.uipanelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel uipanelLogin;
        private System.Windows.Forms.Panel uipanelLoading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uibuttonSignin;
        private System.Windows.Forms.CheckBox uicheckBoxRemember;
        private System.Windows.Forms.TextBox uitextBoxPassword;
        private System.Windows.Forms.TextBox uitextBoxUsername;
        private System.Windows.Forms.CheckBox uicheckBoxInvisible;
        private System.Windows.Forms.FlowLayoutPanel uiflowLayoutPanelBuddies;
        private System.Windows.Forms.MenuStrip uimenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem messengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatRoomsToolStripMenuItem;
        private System.Windows.Forms.Panel uipanelSearch;
        private System.Windows.Forms.Panel uipanelinfo;
        private System.Windows.Forms.PictureBox uipictureBoxBuddyProfile;
        private System.Windows.Forms.TextBox uitextBoxSearch;
        private System.Windows.Forms.Button uibuttonAdd;
        private System.Windows.Forms.ComboBox uicomboBoxStatus;
        private System.Windows.Forms.Label uilabelBuddyName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label uilabelLogging;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;


    }
}
