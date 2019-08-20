﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Oscillate_Gui_Wallet
{
    public partial class OpenWallet : Form
    {
        public OpenWallet()
        {
            InitializeComponent();

            // Init Nodes
            foreach (string Nodes in Config.Nodes)
            {
                nodeList.Items.Add(Nodes);
            }

            // Select default node
            nodeList.SelectedItem = "127.0.0.1:11421";
        }

        private void openWalletBtn_Click(object sender, EventArgs e)
        {
            WalletOpen walletOpen = new WalletOpen();
            walletOpen.daemonHost = "134.209.75.124";
            walletOpen.daemonPort = 11246;
            walletOpen.filename = walletFile.Text + ".wallet";
            walletOpen.password = walletPassword.Text;

            string walletOpenJson = JsonConvert.SerializeObject(walletOpen);
            string response = ApiClient.HTTP(walletOpenJson, "/wallet/open", "POST");
            
            if (response.StartsWith("{")) { // If reply is Json
                JObject JsonParse = JObject.Parse(response);
                int errorCode = (int)JsonParse["errorCode"];
                string errorMessage = (string)JsonParse["errorMessage"];
                MessageBox.Show(errorMessage);
            } else if (response == "403") { // If wallet already opened
                MessageBox.Show("There is already a wallet opened.");
            } else if(response == "") { // If success
                MessageBox.Show("Logged in");
                this.Hide();

                Wallet wallet = new Wallet();
                wallet.Show();
            }
            else { // Other
                MessageBox.Show(response);
            }
        }

        private void createWalletBtn_Click(object sender, EventArgs e)
        {
            CreateWallet walletOpen = new CreateWallet();
            walletOpen.daemonHost = "134.209.75.124";
            walletOpen.daemonPort = 11246;
            walletOpen.filename = walletFile.Text + ".wallet";
            walletOpen.password = walletPassword.Text;

            string walletOpenJson = JsonConvert.SerializeObject(walletOpen);
            string response = ApiClient.HTTP(walletOpenJson, "/wallet/create", "POST");

            if (response.StartsWith("{"))
            { // If reply is Json
                JObject JsonParse = JObject.Parse(response);
                int errorCode = (int)JsonParse["errorCode"];
                string errorMessage = (string)JsonParse["errorMessage"];
                MessageBox.Show(errorMessage);
            }
            else if (response == "403")
            { // If wallet already opened
                MessageBox.Show("There is already a wallet opened.");
            }
            else if (response == "")
            { // If success
                MessageBox.Show("Wallet created");
                this.Hide();

                Wallet wallet = new Wallet();
                wallet.Show();
            }
            else
            { // Other
                MessageBox.Show(response);
            }
        }
    }
}
