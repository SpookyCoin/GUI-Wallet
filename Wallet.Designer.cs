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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.overviewTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.transactionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
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
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 338);
            this.tabControl1.TabIndex = 1;
            // 
            // overviewTab
            // 
            this.overviewTab.Controls.Add(this.pictureBox3);
            this.overviewTab.Controls.Add(this.pictureBox2);
            this.overviewTab.Controls.Add(this.pictureBox1);
            this.overviewTab.Controls.Add(this.primaryAddressValue);
            this.overviewTab.Controls.Add(this.groupBox2);
            this.overviewTab.Controls.Add(this.groupBox1);
            this.overviewTab.Location = new System.Drawing.Point(4, 22);
            this.overviewTab.Name = "overviewTab";
            this.overviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTab.Size = new System.Drawing.Size(966, 312);
            this.overviewTab.TabIndex = 0;
            this.overviewTab.Text = "Overview";
            this.overviewTab.UseVisualStyleBackColor = true;
            // 
            // primaryAddressValue
            // 
            this.primaryAddressValue.AutoSize = true;
            this.primaryAddressValue.Location = new System.Drawing.Point(161, 15);
            this.primaryAddressValue.Name = "primaryAddressValue";
            this.primaryAddressValue.Size = new System.Drawing.Size(54, 13);
            this.primaryAddressValue.TabIndex = 3;
            this.primaryAddressValue.Text = "Address: -";
            this.primaryAddressValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CopyAddress);
            // 
            // groupBox2
            // 
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
            this.transactionsTab.Controls.Add(this.transactionsGrid);
            this.transactionsTab.Location = new System.Drawing.Point(4, 22);
            this.transactionsTab.Name = "transactionsTab";
            this.transactionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsTab.Size = new System.Drawing.Size(966, 312);
            this.transactionsTab.TabIndex = 1;
            this.transactionsTab.Text = "Transactions";
            this.transactionsTab.UseVisualStyleBackColor = true;
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.AllowUserToResizeRows = false;
            this.transactionsGrid.BackgroundColor = System.Drawing.Color.White;
            this.transactionsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrid.Location = new System.Drawing.Point(3, 6);
            this.transactionsGrid.MultiSelect = false;
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.ReadOnly = true;
            this.transactionsGrid.RowHeadersVisible = false;
            this.transactionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsGrid.Size = new System.Drawing.Size(951, 300);
            this.transactionsGrid.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::SpookyCoin_Gui_Wallet.Properties.Resources.spookycointext;
            this.pictureBox3.Location = new System.Drawing.Point(119, 237);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 13);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::SpookyCoin_Gui_Wallet.Properties.Resources.walletv100text;
            this.pictureBox2.Location = new System.Drawing.Point(119, 252);
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
            this.pictureBox1.Location = new System.Drawing.Point(13, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Wallet";
            this.Text = "Wallet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.overviewTab.ResumeLayout(false);
            this.overviewTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.transactionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
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
        private System.Windows.Forms.Label primaryAddressValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView transactionsGrid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}