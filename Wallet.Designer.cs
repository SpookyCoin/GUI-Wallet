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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hashrateLbl = new System.Windows.Forms.Label();
            this.hashrateValue = new System.Windows.Forms.Label();
            this.blockchainHeightValue = new System.Windows.Forms.Label();
            this.blockchainHeightLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unlockedLbl = new System.Windows.Forms.Label();
            this.unlockedValue = new System.Windows.Forms.Label();
            this.lockedLbl = new System.Windows.Forms.Label();
            this.lockedValue = new System.Windows.Forms.Label();
            this.primaryAddressValue = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 205);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 204);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.primaryAddressValue);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.hashrateLbl);
            this.groupBox1.Controls.Add(this.hashrateValue);
            this.groupBox1.Controls.Add(this.blockchainHeightValue);
            this.groupBox1.Controls.Add(this.blockchainHeightLbl);
            this.groupBox1.Location = new System.Drawing.Point(605, 85);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lockedValue);
            this.groupBox2.Controls.Add(this.lockedLbl);
            this.groupBox2.Controls.Add(this.unlockedValue);
            this.groupBox2.Controls.Add(this.unlockedLbl);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance";
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
            // unlockedValue
            // 
            this.unlockedValue.AutoSize = true;
            this.unlockedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockedValue.Location = new System.Drawing.Point(6, 29);
            this.unlockedValue.Name = "unlockedValue";
            this.unlockedValue.Size = new System.Drawing.Size(15, 16);
            this.unlockedValue.TabIndex = 1;
            this.unlockedValue.Text = "0";
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
            // lockedValue
            // 
            this.lockedValue.AutoSize = true;
            this.lockedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockedValue.Location = new System.Drawing.Point(6, 67);
            this.lockedValue.Name = "lockedValue";
            this.lockedValue.Size = new System.Drawing.Size(15, 16);
            this.lockedValue.TabIndex = 3;
            this.lockedValue.Text = "0";
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
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 227);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Wallet";
            this.Text = "Wallet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}