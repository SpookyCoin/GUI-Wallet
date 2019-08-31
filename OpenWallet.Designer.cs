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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenWallet));
            this.openWalletBtn = new System.Windows.Forms.Button();
            this.walletFile = new System.Windows.Forms.TextBox();
            this.walletFileLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nodeList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.walletPassword = new System.Windows.Forms.TextBox();
            this.createWalletBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.browseFile = new System.Windows.Forms.OpenFileDialog();
            this.browseWalletFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openWalletBtn
            // 
            this.openWalletBtn.Location = new System.Drawing.Point(129, 302);
            this.openWalletBtn.Name = "openWalletBtn";
            this.openWalletBtn.Size = new System.Drawing.Size(96, 31);
            this.openWalletBtn.TabIndex = 4;
            this.openWalletBtn.Text = "Open wallet";
            this.openWalletBtn.UseVisualStyleBackColor = true;
            this.openWalletBtn.Click += new System.EventHandler(this.openWalletBtn_Click);
            // 
            // walletFile
            // 
            this.walletFile.Location = new System.Drawing.Point(27, 154);
            this.walletFile.Name = "walletFile";
            this.walletFile.Size = new System.Drawing.Size(117, 20);
            this.walletFile.TabIndex = 0;
            // 
            // walletFileLbl
            // 
            this.walletFileLbl.AutoSize = true;
            this.walletFileLbl.Location = new System.Drawing.Point(24, 138);
            this.walletFileLbl.Name = "walletFileLbl";
            this.walletFileLbl.Size = new System.Drawing.Size(69, 13);
            this.walletFileLbl.TabIndex = 3;
            this.walletFileLbl.Text = "Wallet name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SpookyCoin_Gui_Wallet.Properties.Resources.spookycoin;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nodeList
            // 
            this.nodeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nodeList.FormattingEnabled = true;
            this.nodeList.Location = new System.Drawing.Point(27, 262);
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(198, 21);
            this.nodeList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Node:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // walletPassword
            // 
            this.walletPassword.Location = new System.Drawing.Point(27, 207);
            this.walletPassword.Name = "walletPassword";
            this.walletPassword.PasswordChar = '*';
            this.walletPassword.Size = new System.Drawing.Size(198, 20);
            this.walletPassword.TabIndex = 1;
            // 
            // createWalletBtn
            // 
            this.createWalletBtn.Location = new System.Drawing.Point(27, 302);
            this.createWalletBtn.Name = "createWalletBtn";
            this.createWalletBtn.Size = new System.Drawing.Size(96, 31);
            this.createWalletBtn.TabIndex = 3;
            this.createWalletBtn.Text = "Create wallet";
            this.createWalletBtn.UseVisualStyleBackColor = true;
            this.createWalletBtn.Click += new System.EventHandler(this.createWalletBtn_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(88, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "skip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // browseFile
            // 
            this.browseFile.FileName = "openFileDialog1";
            // 
            // browseWalletFile
            // 
            this.browseWalletFile.Location = new System.Drawing.Point(150, 153);
            this.browseWalletFile.Name = "browseWalletFile";
            this.browseWalletFile.Size = new System.Drawing.Size(75, 22);
            this.browseWalletFile.TabIndex = 10;
            this.browseWalletFile.Text = "Browse...";
            this.browseWalletFile.UseVisualStyleBackColor = true;
            this.browseWalletFile.Click += new System.EventHandler(this.browseWalletFile_Click);
            // 
            // OpenWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 358);
            this.Controls.Add(this.browseWalletFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createWalletBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.walletPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nodeList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.walletFileLbl);
            this.Controls.Add(this.walletFile);
            this.Controls.Add(this.openWalletBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenWallet";
            this.Text = "Open wallet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openWalletBtn;
        private System.Windows.Forms.TextBox walletFile;
        private System.Windows.Forms.Label walletFileLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox nodeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox walletPassword;
        private System.Windows.Forms.Button createWalletBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog browseFile;
        private System.Windows.Forms.Button browseWalletFile;
    }
}

