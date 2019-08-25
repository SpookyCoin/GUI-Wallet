using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SpookyCoin_Gui_Wallet
{
    public partial class OpenWallet : Form
    {
        public OpenWallet()
        {
            InitializeComponent();
            
            // Start API
            ProcessStartInfo startAPI = new ProcessStartInfo();
            startAPI.FileName = Path.GetFileName("wallet-api.exe");
            startAPI.Arguments = "--rpc-password kevin11 --port 8070";
            startAPI.CreateNoWindow = true;
            startAPI.UseShellExecute = false;
            Process.Start(startAPI);
            

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
            walletOpen.daemonHost = "spookypool.nl";
            walletOpen.daemonPort = 11421;
            walletOpen.filename = walletFile.Text;
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
            CreateWallet createWallet = new CreateWallet();
            createWallet.daemonHost = "spookypool.nl";
            createWallet.daemonPort = 11421;
            createWallet.filename = walletFile.Text;
            createWallet.password = walletPassword.Text;

            string createWalletJson = JsonConvert.SerializeObject(createWallet);
            string response = ApiClient.HTTP(createWalletJson, "/wallet/create", "POST");

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Wallet wallet = new Wallet();
            wallet.Show();
        }

        private void browseWalletFile_Click(object sender, EventArgs e)
        {
            DialogResult result = browseFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = browseFile.FileName;
                try
                {
                    walletFile.Text = browseFile.InitialDirectory + browseFile.FileName;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void exit(object sender, FormClosingEventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("wallet-api"))
            {
                process.Kill();
            }
        }
    }
}
