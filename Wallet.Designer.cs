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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labeblockchainHeight = new System.Windows.Forms.Label();
            this.labenodeIP = new System.Windows.Forms.Label();
            this.labeaddress = new System.Windows.Forms.Label();
            this.labeunlockedBalance = new System.Windows.Forms.Label();
            this.labelockedBalance = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelockedBalance);
            this.tabPage1.Controls.Add(this.labeunlockedBalance);
            this.tabPage1.Controls.Add(this.labeaddress);
            this.tabPage1.Controls.Add(this.labenodeIP);
            this.tabPage1.Controls.Add(this.labeblockchainHeight);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "You are connected to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Blockchain Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wallet Overview";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Locked Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unlocked Balance: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your address:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SpookyCoin_Gui_Wallet.Properties.Resources.spookycoin;
            this.pictureBox1.Location = new System.Drawing.Point(353, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Send Transaction";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labeblockchainHeight
            // 
            this.labeblockchainHeight.AutoSize = true;
            this.labeblockchainHeight.Location = new System.Drawing.Point(45, 52);
            this.labeblockchainHeight.Name = "labeblockchainHeight";
            this.labeblockchainHeight.Size = new System.Drawing.Size(90, 13);
            this.labeblockchainHeight.TabIndex = 12;
            this.labeblockchainHeight.Text = "blockchainHeight";
            // 
            // labenodeIP
            // 
            this.labenodeIP.AutoSize = true;
            this.labenodeIP.Location = new System.Drawing.Point(704, 52);
            this.labenodeIP.Name = "labenodeIP";
            this.labenodeIP.Size = new System.Drawing.Size(41, 13);
            this.labenodeIP.TabIndex = 13;
            this.labenodeIP.Text = "nodeIP";
            // 
            // labeaddress
            // 
            this.labeaddress.AutoSize = true;
            this.labeaddress.Location = new System.Drawing.Point(386, 228);
            this.labeaddress.Name = "labeaddress";
            this.labeaddress.Size = new System.Drawing.Size(44, 13);
            this.labeaddress.TabIndex = 14;
            this.labeaddress.Text = "address";
            // 
            // labeunlockedBalance
            // 
            this.labeunlockedBalance.AutoSize = true;
            this.labeunlockedBalance.Location = new System.Drawing.Point(365, 323);
            this.labeunlockedBalance.Name = "labeunlockedBalance";
            this.labeunlockedBalance.Size = new System.Drawing.Size(90, 13);
            this.labeunlockedBalance.TabIndex = 15;
            this.labeunlockedBalance.Text = "unlockedBalance";
            // 
            // labelockedBalance
            // 
            this.labelockedBalance.AutoSize = true;
            this.labelockedBalance.Location = new System.Drawing.Point(365, 394);
            this.labelockedBalance.Name = "labelockedBalance";
            this.labelockedBalance.Size = new System.Drawing.Size(78, 13);
            this.labelockedBalance.TabIndex = 16;
            this.labelockedBalance.Text = "lockedBalance";
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "Wallet";
            this.Text = "Wallet";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelockedBalance;
        private System.Windows.Forms.Label labeunlockedBalance;
        private System.Windows.Forms.Label labeaddress;
        private System.Windows.Forms.Label labenodeIP;
        private System.Windows.Forms.Label labeblockchainHeight;
    }
}