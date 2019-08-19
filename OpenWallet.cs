using Newtonsoft.Json;
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
using System.Windows.Forms;

namespace SpookyCoin_Gui_Wallet
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

        private void button1_Click(object sender, EventArgs e)
        {
            WalletOpen wallet = new WalletOpen();
            wallet.daemonHost = "spookypool.nl";
            wallet.daemonPort = 11421;
            wallet.filename = "mywallet.wallet";
            wallet.password = "kevin11";

            string json = JsonConvert.SerializeObject(wallet);

            //MessageBox.Show(ApiClient.HTTP(json, "/wallet/open", "POST"));

            MessageBox.Show(ApiClient.HTTP("", "/addresses", "GET"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
