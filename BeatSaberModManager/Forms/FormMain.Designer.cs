﻿namespace BeatSaberModManager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonViewInfo = new System.Windows.Forms.Button();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCore = new System.Windows.Forms.TabPage();
            this.listViewMods = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageCredits = new System.Windows.Forms.TabPage();
            this.linkLabelContributors = new System.Windows.Forms.LinkLabel();
            this.linkLabellolPants = new System.Windows.Forms.LinkLabel();
            this.linkLabelUmbranox = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelModSaber2 = new System.Windows.Forms.Label();
            this.linkLabelModSaberLink = new System.Windows.Forms.LinkLabel();
            this.labelModSaber1 = new System.Windows.Forms.Label();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelDiscord = new System.Windows.Forms.LinkLabel();
            this.labelDiscordInfo = new System.Windows.Forms.Label();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.helpInfoLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPluginsPath = new System.Windows.Forms.TextBox();
            this.helpInfoLabel3 = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.webBrowserDescription = new System.Windows.Forms.WebBrowser();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageCore.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.tabPageCredits.SuspendLayout();
            this.tabPageHelp.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tableLayoutPanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.Location = new System.Drawing.Point(15, 602);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(241, 145);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status: Null";
            // 
            // buttonViewInfo
            // 
            this.buttonViewInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewInfo.Enabled = false;
            this.buttonViewInfo.Location = new System.Drawing.Point(262, 602);
            this.buttonViewInfo.Name = "buttonViewInfo";
            this.buttonViewInfo.Size = new System.Drawing.Size(158, 23);
            this.buttonViewInfo.TabIndex = 9;
            this.buttonViewInfo.Text = "View Selected Mod Info";
            this.buttonViewInfo.UseVisualStyleBackColor = true;
            this.buttonViewInfo.Click += new System.EventHandler(this.buttonViewInfo_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstall.Location = new System.Drawing.Point(426, 602);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(112, 23);
            this.buttonInstall.TabIndex = 4;
            this.buttonInstall.Text = "Install / Update";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageCore);
            this.tabControlMain.Controls.Add(this.tabPageCredits);
            this.tabControlMain.Controls.Add(this.tabPageHelp);
            this.tabControlMain.Enabled = false;
            this.tabControlMain.Location = new System.Drawing.Point(14, 147);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(528, 449);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageCore
            // 
            this.tabPageCore.Controls.Add(this.listViewMods);
            this.tabPageCore.Location = new System.Drawing.Point(4, 22);
            this.tabPageCore.Name = "tabPageCore";
            this.tabPageCore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCore.Size = new System.Drawing.Size(520, 423);
            this.tabPageCore.TabIndex = 0;
            this.tabPageCore.Text = "Plugins";
            this.tabPageCore.UseVisualStyleBackColor = true;
            // 
            // listViewMods
            // 
            this.listViewMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMods.CheckBoxes = true;
            this.listViewMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderAuthor,
            this.columnHeaderVersion});
            this.listViewMods.ContextMenuStrip = this.contextMenuStripMain;
            this.listViewMods.FullRowSelect = true;
            this.listViewMods.Location = new System.Drawing.Point(6, 6);
            this.listViewMods.Name = "listViewMods";
            this.listViewMods.Size = new System.Drawing.Size(508, 411);
            this.listViewMods.TabIndex = 0;
            this.listViewMods.UseCompatibleStateImageBehavior = false;
            this.listViewMods.View = System.Windows.Forms.View.Details;
            this.listViewMods.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewMods_ItemChecked);
            this.listViewMods.SelectedIndexChanged += new System.EventHandler(this.listViewMods_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 261;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 150;
            // 
            // columnHeaderVersion
            // 
            this.columnHeaderVersion.Text = "Version";
            this.columnHeaderVersion.Width = 107;
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(124, 26);
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.viewInfoToolStripMenuItem.Text = "View Info";
            this.viewInfoToolStripMenuItem.Click += new System.EventHandler(this.viewInfoToolStripMenuItem_Click);
            // 
            // tabPageCredits
            // 
            this.tabPageCredits.Controls.Add(this.linkLabelContributors);
            this.tabPageCredits.Controls.Add(this.linkLabellolPants);
            this.tabPageCredits.Controls.Add(this.linkLabelUmbranox);
            this.tabPageCredits.Controls.Add(this.label3);
            this.tabPageCredits.Controls.Add(this.labelModSaber2);
            this.tabPageCredits.Controls.Add(this.linkLabelModSaberLink);
            this.tabPageCredits.Controls.Add(this.labelModSaber1);
            this.tabPageCredits.Location = new System.Drawing.Point(4, 22);
            this.tabPageCredits.Name = "tabPageCredits";
            this.tabPageCredits.Size = new System.Drawing.Size(520, 432);
            this.tabPageCredits.TabIndex = 1;
            this.tabPageCredits.Text = "Mod Manager Credits";
            this.tabPageCredits.UseVisualStyleBackColor = true;
            // 
            // linkLabelContributors
            // 
            this.linkLabelContributors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelContributors.AutoSize = true;
            this.linkLabelContributors.Location = new System.Drawing.Point(213, 239);
            this.linkLabelContributors.Name = "linkLabelContributors";
            this.linkLabelContributors.Size = new System.Drawing.Size(73, 13);
            this.linkLabelContributors.TabIndex = 7;
            this.linkLabelContributors.TabStop = true;
            this.linkLabelContributors.Text = "Contributors";
            this.linkLabelContributors.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContributors_LinkClicked);
            // 
            // linkLabellolPants
            // 
            this.linkLabellolPants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabellolPants.AutoSize = true;
            this.linkLabellolPants.Location = new System.Drawing.Point(367, 194);
            this.linkLabellolPants.Name = "linkLabellolPants";
            this.linkLabellolPants.Size = new System.Drawing.Size(48, 13);
            this.linkLabellolPants.TabIndex = 5;
            this.linkLabellolPants.TabStop = true;
            this.linkLabellolPants.Text = "lolPants";
            this.linkLabellolPants.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabellolPants_LinkClicked);
            // 
            // linkLabelUmbranox
            // 
            this.linkLabelUmbranox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelUmbranox.AutoSize = true;
            this.linkLabelUmbranox.Location = new System.Drawing.Point(283, 216);
            this.linkLabelUmbranox.Name = "linkLabelUmbranox";
            this.linkLabelUmbranox.Size = new System.Drawing.Size(60, 13);
            this.linkLabelUmbranox.TabIndex = 4;
            this.linkLabelUmbranox.TabStop = true;
            this.linkLabelUmbranox.Text = "Umbranox";
            this.linkLabelUmbranox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUmbranox_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mod Installer created by ";
            // 
            // labelModSaber2
            // 
            this.labelModSaber2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelModSaber2.AutoSize = true;
            this.labelModSaber2.Location = new System.Drawing.Point(310, 194);
            this.labelModSaber2.Name = "labelModSaber2";
            this.labelModSaber2.Size = new System.Drawing.Size(60, 13);
            this.labelModSaber2.TabIndex = 2;
            this.labelModSaber2.Text = "created by";
            // 
            // linkLabelModSaberLink
            // 
            this.linkLabelModSaberLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelModSaberLink.AutoSize = true;
            this.linkLabelModSaberLink.Location = new System.Drawing.Point(254, 194);
            this.linkLabelModSaberLink.Name = "linkLabelModSaberLink";
            this.linkLabelModSaberLink.Size = new System.Drawing.Size(60, 13);
            this.linkLabelModSaberLink.TabIndex = 1;
            this.linkLabelModSaberLink.TabStop = true;
            this.linkLabelModSaberLink.Text = "ModSaber";
            this.linkLabelModSaberLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelModSaberLink_LinkClicked);
            // 
            // labelModSaber1
            // 
            this.labelModSaber1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelModSaber1.AutoSize = true;
            this.labelModSaber1.Location = new System.Drawing.Point(73, 194);
            this.labelModSaber1.Name = "labelModSaber1";
            this.labelModSaber1.Size = new System.Drawing.Size(187, 13);
            this.labelModSaber1.TabIndex = 0;
            this.labelModSaber1.Text = "Mod Hosting Platform Provided by ";
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.label4);
            this.tabPageHelp.Controls.Add(this.linkLabelDiscord);
            this.tabPageHelp.Controls.Add(this.labelDiscordInfo);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHelp.Size = new System.Drawing.Size(520, 432);
            this.tabPageHelp.TabIndex = 2;
            this.tabPageHelp.Text = "Help";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Need more help?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelDiscord
            // 
            this.linkLabelDiscord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelDiscord.AutoSize = true;
            this.linkLabelDiscord.Location = new System.Drawing.Point(170, 239);
            this.linkLabelDiscord.Name = "linkLabelDiscord";
            this.linkLabelDiscord.Size = new System.Drawing.Size(145, 13);
            this.linkLabelDiscord.TabIndex = 1;
            this.linkLabelDiscord.TabStop = true;
            this.linkLabelDiscord.Text = "discord.gg/beatsabermods";
            this.linkLabelDiscord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelDiscord.Click += new System.EventHandler(this.linkLabelDiscord_Click);
            // 
            // labelDiscordInfo
            // 
            this.labelDiscordInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDiscordInfo.AutoSize = true;
            this.labelDiscordInfo.Location = new System.Drawing.Point(98, 216);
            this.labelDiscordInfo.Name = "labelDiscordInfo";
            this.labelDiscordInfo.Size = new System.Drawing.Size(303, 13);
            this.labelDiscordInfo.TabIndex = 0;
            this.labelDiscordInfo.Text = "Join us on the Beat Saber Modding Group Discord server!";
            this.labelDiscordInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFolderBrowser.Location = new System.Drawing.Point(512, 30);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(26, 23);
            this.buttonFolderBrowser.TabIndex = 1;
            this.buttonFolderBrowser.Text = "..";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.SystemColors.Info;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.tableLayoutPanelInfo);
            this.panelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInfo.Location = new System.Drawing.Point(14, 58);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(524, 80);
            this.panelInfo.TabIndex = 10;
            // 
            // tableLayoutPanelInfo
            // 
            this.tableLayoutPanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelInfo.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelInfo.ColumnCount = 1;
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInfo.Controls.Add(this.helpInfoLabel1, 0, 0);
            this.tableLayoutPanelInfo.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanelInfo.Controls.Add(this.textBoxPluginsPath, 0, 1);
            this.tableLayoutPanelInfo.Controls.Add(this.helpInfoLabel3, 0, 3);
            this.tableLayoutPanelInfo.Location = new System.Drawing.Point(-1, 3);
            this.tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            this.tableLayoutPanelInfo.RowCount = 5;
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelInfo.Size = new System.Drawing.Size(524, 79);
            this.tableLayoutPanelInfo.TabIndex = 13;
            // 
            // helpInfoLabel1
            // 
            this.helpInfoLabel1.AutoSize = true;
            this.helpInfoLabel1.Location = new System.Drawing.Point(3, 0);
            this.helpInfoLabel1.Name = "helpInfoLabel1";
            this.helpInfoLabel1.Size = new System.Drawing.Size(269, 13);
            this.helpInfoLabel1.TabIndex = 0;
            this.helpInfoLabel1.Text = "Most mods will install a .dll into the Plugins folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Right click on a mod in the list below to view more info about that mod.";
            // 
            // textBoxPluginsPath
            // 
            this.textBoxPluginsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPluginsPath.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPluginsPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPluginsPath.Location = new System.Drawing.Point(6, 17);
            this.textBoxPluginsPath.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxPluginsPath.Name = "textBoxPluginsPath";
            this.textBoxPluginsPath.ReadOnly = true;
            this.textBoxPluginsPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxPluginsPath.Size = new System.Drawing.Size(515, 15);
            this.textBoxPluginsPath.TabIndex = 5;
            this.textBoxPluginsPath.Click += new System.EventHandler(this.textBoxPluginsPath_Click);
            this.textBoxPluginsPath.Leave += new System.EventHandler(this.textBoxPluginsPath_Leave);
            // 
            // helpInfoLabel3
            // 
            this.helpInfoLabel3.AutoSize = true;
            this.helpInfoLabel3.Location = new System.Drawing.Point(3, 42);
            this.helpInfoLabel3.Name = "helpInfoLabel3";
            this.helpInfoLabel3.Size = new System.Drawing.Size(318, 13);
            this.helpInfoLabel3.TabIndex = 3;
            this.helpInfoLabel3.Text = "You can uninstall mods by removing the .dll from that folder.";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Enabled = false;
            this.textBoxDirectory.Location = new System.Drawing.Point(14, 30);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(492, 22);
            this.textBoxDirectory.TabIndex = 0;
            this.textBoxDirectory.TextChanged += new System.EventHandler(this.textBoxDirectory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Beat Saber Folder Path:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlMain);
            this.splitContainer1.Panel1.Controls.Add(this.panelInfo);
            this.splitContainer1.Panel1.Controls.Add(this.labelStatus);
            this.splitContainer1.Panel1.Controls.Add(this.buttonViewInfo);
            this.splitContainer1.Panel1.Controls.Add(this.buttonInstall);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFolderBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelDescription);
            this.splitContainer1.Panel2.Controls.Add(this.labelTitle);
            this.splitContainer1.Panel2.Controls.Add(this.panelDescription);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 637);
            this.splitContainer1.SplitterDistance = 545;
            this.splitContainer1.TabIndex = 11;
            // 
            // panelDescription
            // 
            this.panelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescription.Controls.Add(this.webBrowserDescription);
            this.panelDescription.Location = new System.Drawing.Point(3, 58);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(526, 567);
            this.panelDescription.TabIndex = 6;
            // 
            // webBrowserDescription
            // 
            this.webBrowserDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserDescription.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserDescription.Location = new System.Drawing.Point(0, 0);
            this.webBrowserDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserDescription.Name = "webBrowserDescription";
            this.webBrowserDescription.Size = new System.Drawing.Size(524, 565);
            this.webBrowserDescription.TabIndex = 6;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(249, 20);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Mod Name by Author Name Version";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(4, 39);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(69, 13);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 637);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beat Saber Mod Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCore.ResumeLayout(false);
            this.contextMenuStripMain.ResumeLayout(false);
            this.tabPageCredits.ResumeLayout(false);
            this.tabPageCredits.PerformLayout();
            this.tabPageHelp.ResumeLayout(false);
            this.tabPageHelp.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCore;
        private System.Windows.Forms.ListView listViewMods;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageCredits;
        private System.Windows.Forms.Button buttonViewInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderVersion;
        private System.Windows.Forms.LinkLabel linkLabelUmbranox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelModSaber2;
        private System.Windows.Forms.LinkLabel linkLabelModSaberLink;
        private System.Windows.Forms.Label labelModSaber1;
        private System.Windows.Forms.LinkLabel linkLabellolPants;
        private System.Windows.Forms.LinkLabel linkLabelContributors;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfo;
        private System.Windows.Forms.Label helpInfoLabel1;
        private System.Windows.Forms.Label helpInfoLabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPluginsPath;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.Label labelDiscordInfo;
        private System.Windows.Forms.LinkLabel linkLabelDiscord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.WebBrowser webBrowserDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
    }
}

