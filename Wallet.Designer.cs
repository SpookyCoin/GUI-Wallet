namespace SpookyCoin_Gui_Wallet
{
    partial class Wallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallet));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.overviewTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.primaryAddressValue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lockedValue = new System.Windows.Forms.Label();
            this.lockedLbl = new System.Windows.Forms.Label();
            this.unlockedValue = new System.Windows.Forms.Label();
            this.unlockedLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hashrateLbl = new System.Windows.Forms.Label();
            this.hashrateValue = new System.Windows.Forms.Label();
            this.blockchainHeightValue = new System.Windows.Forms.Label();
            this.blockchainHeightLbl = new System.Windows.Forms.Label();
            this.transactionsTab = new System.Windows.Forms.TabPage();
            this.transactionsGrid = new System.Windows.Forms.DataGridView();
            this.sendTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mixinLst = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.feeTxt = new System.Windows.Forms.TextBox();
            this.spkyLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.walletAddressTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentIdTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPrivateKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.overviewTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.transactionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            this.sendTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(889, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(163, 17);
            this.toolStripStatusLabel1.Text = "Connected to: 127.0.0.1:11421";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.overviewTab);
            this.tabControl1.Controls.Add(this.transactionsTab);
            this.tabControl1.Controls.Add(this.sendTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 343);
            this.tabControl1.TabIndex = 1;
            // 
            // overviewTab
            // 
            this.overviewTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.overviewTab.Controls.Add(this.groupBox3);
            this.overviewTab.Controls.Add(this.pictureBox3);
            this.overviewTab.Controls.Add(this.pictureBox2);
            this.overviewTab.Controls.Add(this.pictureBox1);
            this.overviewTab.Controls.Add(this.groupBox2);
            this.overviewTab.Controls.Add(this.groupBox1);
            this.overviewTab.Location = new System.Drawing.Point(4, 22);
            this.overviewTab.Name = "overviewTab";
            this.overviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTab.Size = new System.Drawing.Size(880, 317);
            this.overviewTab.TabIndex = 0;
            this.overviewTab.Text = "Overview";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.primaryAddressValue);
            this.groupBox3.Location = new System.Drawing.Point(160, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(697, 40);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address";
            // 
            // primaryAddressValue
            // 
            this.primaryAddressValue.AutoSize = true;
            this.primaryAddressValue.Location = new System.Drawing.Point(6, 16);
            this.primaryAddressValue.Name = "primaryAddressValue";
            this.primaryAddressValue.Size = new System.Drawing.Size(10, 13);
            this.primaryAddressValue.TabIndex = 7;
            this.primaryAddressValue.Text = "-";
            this.primaryAddressValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CopyAddress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lockedValue);
            this.groupBox2.Controls.Add(this.lockedLbl);
            this.groupBox2.Controls.Add(this.unlockedValue);
            this.groupBox2.Controls.Add(this.unlockedLbl);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance";
            // 
            // lockedValue
            // 
            this.lockedValue.AutoSize = true;
            this.lockedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lockedValue.Location = new System.Drawing.Point(6, 67);
            this.lockedValue.Name = "lockedValue";
            this.lockedValue.Size = new System.Drawing.Size(13, 13);
            this.lockedValue.TabIndex = 3;
            this.lockedValue.Text = "0";
            // 
            // lockedLbl
            // 
            this.lockedLbl.AutoSize = true;
            this.lockedLbl.Location = new System.Drawing.Point(6, 54);
            this.lockedLbl.Name = "lockedLbl";
            this.lockedLbl.Size = new System.Drawing.Size(46, 13);
            this.lockedLbl.TabIndex = 2;
            this.lockedLbl.Text = "Locked:";
            // 
            // unlockedValue
            // 
            this.unlockedValue.AutoSize = true;
            this.unlockedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.unlockedValue.Location = new System.Drawing.Point(6, 29);
            this.unlockedValue.Name = "unlockedValue";
            this.unlockedValue.Size = new System.Drawing.Size(13, 13);
            this.unlockedValue.TabIndex = 1;
            this.unlockedValue.Text = "0";
            // 
            // unlockedLbl
            // 
            this.unlockedLbl.AutoSize = true;
            this.unlockedLbl.Location = new System.Drawing.Point(6, 16);
            this.unlockedLbl.Name = "unlockedLbl";
            this.unlockedLbl.Size = new System.Drawing.Size(56, 13);
            this.unlockedLbl.TabIndex = 0;
            this.unlockedLbl.Text = "Unlocked:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hashrateLbl);
            this.groupBox1.Controls.Add(this.hashrateValue);
            this.groupBox1.Controls.Add(this.blockchainHeightValue);
            this.groupBox1.Controls.Add(this.blockchainHeightLbl);
            this.groupBox1.Location = new System.Drawing.Point(7, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // hashrateLbl
            // 
            this.hashrateLbl.AutoSize = true;
            this.hashrateLbl.Location = new System.Drawing.Point(6, 55);
            this.hashrateLbl.Name = "hashrateLbl";
            this.hashrateLbl.Size = new System.Drawing.Size(53, 13);
            this.hashrateLbl.TabIndex = 3;
            this.hashrateLbl.Text = "Hashrate:";
            // 
            // hashrateValue
            // 
            this.hashrateValue.AutoSize = true;
            this.hashrateValue.Location = new System.Drawing.Point(6, 68);
            this.hashrateValue.Name = "hashrateValue";
            this.hashrateValue.Size = new System.Drawing.Size(13, 13);
            this.hashrateValue.TabIndex = 2;
            this.hashrateValue.Text = "0";
            // 
            // blockchainHeightValue
            // 
            this.blockchainHeightValue.AutoSize = true;
            this.blockchainHeightValue.Location = new System.Drawing.Point(6, 29);
            this.blockchainHeightValue.Name = "blockchainHeightValue";
            this.blockchainHeightValue.Size = new System.Drawing.Size(13, 13);
            this.blockchainHeightValue.TabIndex = 1;
            this.blockchainHeightValue.Text = "0";
            // 
            // blockchainHeightLbl
            // 
            this.blockchainHeightLbl.AutoSize = true;
            this.blockchainHeightLbl.Location = new System.Drawing.Point(6, 16);
            this.blockchainHeightLbl.Name = "blockchainHeightLbl";
            this.blockchainHeightLbl.Size = new System.Drawing.Size(97, 13);
            this.blockchainHeightLbl.TabIndex = 0;
            this.blockchainHeightLbl.Text = "Blockchain Height:";
            // 
            // transactionsTab
            // 
            this.transactionsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.transactionsTab.Controls.Add(this.transactionsGrid);
            this.transactionsTab.Location = new System.Drawing.Point(4, 22);
            this.transactionsTab.Name = "transactionsTab";
            this.transactionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsTab.Size = new System.Drawing.Size(693, 317);
            this.transactionsTab.TabIndex = 1;
            this.transactionsTab.Text = "Transactions";
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.AllowUserToResizeRows = false;
            this.transactionsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.transactionsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrid.Location = new System.Drawing.Point(3, 6);
            this.transactionsGrid.MultiSelect = false;
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.ReadOnly = true;
            this.transactionsGrid.RowHeadersVisible = false;
            this.transactionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsGrid.Size = new System.Drawing.Size(684, 308);
            this.transactionsGrid.TabIndex = 0;
            // 
            // sendTab
            // 
            this.sendTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sendTab.Controls.Add(this.groupBox5);
            this.sendTab.Controls.Add(this.groupBox4);
            this.sendTab.Controls.Add(this.sendBtn);
            this.sendTab.Location = new System.Drawing.Point(4, 22);
            this.sendTab.Name = "sendTab";
            this.sendTab.Padding = new System.Windows.Forms.Padding(3);
            this.sendTab.Size = new System.Drawing.Size(693, 317);
            this.sendTab.TabIndex = 2;
            this.sendTab.Text = "Send";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.mixinLst);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.amountTxt);
            this.groupBox5.Controls.Add(this.feeTxt);
            this.groupBox5.Controls.Add(this.spkyLbl);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(6, 112);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(679, 62);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Spending";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mixin:";
            // 
            // mixinLst
            // 
            this.mixinLst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mixinLst.FormattingEnabled = true;
            this.mixinLst.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.mixinLst.Location = new System.Drawing.Point(322, 32);
            this.mixinLst.Name = "mixinLst";
            this.mixinLst.Size = new System.Drawing.Size(50, 21);
            this.mixinLst.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SPKY";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(9, 32);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(89, 20);
            this.amountTxt.TabIndex = 6;
            this.amountTxt.Enter += new System.EventHandler(this.amountEnter);
            this.amountTxt.Leave += new System.EventHandler(this.amountLeave);
            // 
            // feeTxt
            // 
            this.feeTxt.Location = new System.Drawing.Point(155, 32);
            this.feeTxt.Name = "feeTxt";
            this.feeTxt.Size = new System.Drawing.Size(100, 20);
            this.feeTxt.TabIndex = 10;
            this.feeTxt.Enter += new System.EventHandler(this.feeEnter);
            this.feeTxt.Leave += new System.EventHandler(this.feeLeave);
            // 
            // spkyLbl
            // 
            this.spkyLbl.AutoSize = true;
            this.spkyLbl.Location = new System.Drawing.Point(100, 35);
            this.spkyLbl.Name = "spkyLbl";
            this.spkyLbl.Size = new System.Drawing.Size(35, 13);
            this.spkyLbl.TabIndex = 7;
            this.spkyLbl.Text = "SPKY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fee:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.walletAddressTxt);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.paymentIdTxt);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(679, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wallet Address:";
            // 
            // walletAddressTxt
            // 
            this.walletAddressTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.walletAddressTxt.Location = new System.Drawing.Point(9, 32);
            this.walletAddressTxt.Name = "walletAddressTxt";
            this.walletAddressTxt.Size = new System.Drawing.Size(664, 20);
            this.walletAddressTxt.TabIndex = 2;
            this.walletAddressTxt.Tag = "Kanker";
            this.walletAddressTxt.Enter += new System.EventHandler(this.placeholderWalletAddressEnter);
            this.walletAddressTxt.Leave += new System.EventHandler(this.placeholderWalletAddressLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment ID:";
            // 
            // paymentIdTxt
            // 
            this.paymentIdTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentIdTxt.Location = new System.Drawing.Point(9, 71);
            this.paymentIdTxt.Name = "paymentIdTxt";
            this.paymentIdTxt.Size = new System.Drawing.Size(664, 20);
            this.paymentIdTxt.TabIndex = 4;
            this.paymentIdTxt.Enter += new System.EventHandler(this.paymentIdEnter);
            this.paymentIdTxt.Leave += new System.EventHandler(this.paymentIdLeave);
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.Location = new System.Drawing.Point(558, 209);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(97, 31);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exportPrivateKeysToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exportPrivateKeysToolStripMenuItem
            // 
            this.exportPrivateKeysToolStripMenuItem.Name = "exportPrivateKeysToolStripMenuItem";
            this.exportPrivateKeysToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exportPrivateKeysToolStripMenuItem.Text = "Export private keys";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(107, 22);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::SpookyCoin_Gui_Wallet.Properties.Resources.spookycointext;
            this.pictureBox3.Location = new System.Drawing.Point(119, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 13);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::SpookyCoin_Gui_Wallet.Properties.Resources.walletv100text;
            this.pictureBox2.Location = new System.Drawing.Point(119, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 13);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::SpookyCoin_Gui_Wallet.Properties.Resources.spookycoin;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(889, 387);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Wallet";
            this.Text = "Wallet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.overviewTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.transactionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            this.sendTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage overviewTab;
        private System.Windows.Forms.TabPage transactionsTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label blockchainHeightLbl;
        private System.Windows.Forms.Label hashrateLbl;
        private System.Windows.Forms.Label hashrateValue;
        private System.Windows.Forms.Label blockchainHeightValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lockedValue;
        private System.Windows.Forms.Label lockedLbl;
        private System.Windows.Forms.Label unlockedValue;
        private System.Windows.Forms.Label unlockedLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView transactionsGrid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label primaryAddressValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage sendTab;
        private System.Windows.Forms.TextBox walletAddressTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox feeTxt;
        private System.Windows.Forms.Label spkyLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paymentIdTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPrivateKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox mixinLst;
    }
}