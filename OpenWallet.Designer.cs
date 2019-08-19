namespace SpookyCoin_Gui_Wallet
{
    partial class OpenWallet
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
            this.button1 = new System.Windows.Forms.Button();
            this.walletFile = new System.Windows.Forms.TextBox();
            this.walletFileLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nodeList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open wallet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // walletFile
            // 
            this.walletFile.Location = new System.Drawing.Point(60, 154);
            this.walletFile.Name = "walletFile";
            this.walletFile.Size = new System.Drawing.Size(198, 20);
            this.walletFile.TabIndex = 2;
            // 
            // walletFileLbl
            // 
            this.walletFileLbl.AutoSize = true;
            this.walletFileLbl.Location = new System.Drawing.Point(57, 138);
            this.walletFileLbl.Name = "walletFileLbl";
            this.walletFileLbl.Size = new System.Drawing.Size(85, 13);
            this.walletFileLbl.TabIndex = 3;
            this.walletFileLbl.Text = "Wallet Filename:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpookyCoin_Gui_Wallet.Properties.Resources.spookycoin;
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nodeList
            // 
            this.nodeList.FormattingEnabled = true;
            this.nodeList.Location = new System.Drawing.Point(60, 207);
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(198, 21);
            this.nodeList.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Node:";
            // 
            // OpenWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nodeList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.walletFileLbl);
            this.Controls.Add(this.walletFile);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenWallet";
            this.Text = "Open wallet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox walletFile;
        private System.Windows.Forms.Label walletFileLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox nodeList;
        private System.Windows.Forms.Label label1;
    }
}

