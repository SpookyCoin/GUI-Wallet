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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(627, 22);
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
            this.tabControl1.Size = new System.Drawing.Size(626, 412);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hashrateLbl);
            this.groupBox1.Controls.Add(this.hashrateValue);
            this.groupBox1.Controls.Add(this.blockchainHeightValue);
            this.groupBox1.Controls.Add(this.blockchainHeightLbl);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
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
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 435);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Wallet";
            this.Text = "Wallet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}