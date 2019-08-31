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
using System.Net.NetworkInformation;
using System.Net.Sockets;
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
            startAPI.Arguments = "--rpc-password " + Config.API_Password + " --port " + Config.HTTP_Port;
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

        public static bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                using (var client = new TcpClient(hostUri, portNumber))
                    return true;
            }
            catch (SocketException ex)
            {
                return false;
            }
        }

        private void openWalletBtn_Click(object sender, EventArgs e)
        {
            /// Split ip and port on selected node
            string[] node = nodeList.Text.Split(':');

            // If ping to daemon is successfull
            if (PingHost(node[0], Convert.ToInt32(node[1])))
            {
                Config.Connected_Node = nodeList.Text;

                // Open wallet
                WalletOpen walletOpen = new WalletOpen();
                walletOpen.daemonHost = node[0];
                walletOpen.daemonPort = Convert.ToInt32(node[1]);
                walletOpen.filename = walletFile.Text;
                walletOpen.password = walletPassword.Text;

                string walletOpenJson = JsonConvert.SerializeObject(walletOpen);
                string response = ApiClient.HTTP(walletOpenJson, "/wallet/open", "POST");

                if (response.StartsWith("{"))
                { // If reply is Json
                    JObject JsonParse = JObject.Parse(response);
                    int errorCode = (int)JsonParse["errorCode"];
                    string errorMessage = (string)JsonParse["errorMessage"];
                    MessageBox.Show(errorMessage);
                }
                else if (response == "403")
                { // If wallet already opened
                    ApiClient.HTTP("", "/wallet", "DELETE"); // Logout of wallet in API
                    MessageBox.Show("There was still a wallet loaded. It has been unloaded now. Please try again to open a wallet.");
                }
                else if (response == "")
                { // If success
                    //MessageBox.Show("Logged in");
                    this.Hide();

                    Wallet wallet = new Wallet();
                    wallet.Show();
                }
                else
                { // Other
                    MessageBox.Show(response);
                }
            }
            else
            {
                MessageBox.Show("Could not connect to node. Make sure your daemon is running or try a different node.");
            }
        }

        private void createWalletBtn_Click(object sender, EventArgs e)
        {
            /// Split ip and port on selected node
            string[] node = nodeList.Text.Split(':');
            
            // If ping to daemon is successfull
            if (PingHost(node[0], Convert.ToInt32(node[1])))
            {
                Config.Connected_Node = nodeList.Text;

                CreateWallet createWallet = new CreateWallet();
                createWallet.daemonHost = node[0];
                createWallet.daemonPort = Convert.ToInt32(node[1]);
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
                    ApiClient.HTTP("", "/wallet", "DELETE"); // Logout of wallet in API
                    MessageBox.Show("There was still a wallet loaded. It has been unloaded now. Please try again to create a wallet.");
                }
                else if (response == "")
                { // If success
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
