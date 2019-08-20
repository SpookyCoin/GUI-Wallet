using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpookyCoin_Gui_Wallet
{
    public partial class Wallet : Form
    {
        public Wallet()
        {
            InitializeComponent();

            GetInformation();

            // Get Primary Address
            string primaryAddress = ApiClient.HTTP("", "/addresses/primary", "GET");
            if (primaryAddress.StartsWith("{"))
            {
                JObject JsonParse = JObject.Parse(primaryAddress);
                string address = (string)JsonParse["address"];

                primaryAddressValue.Text = "Address: " + address;
                Config.PrimaryAddress = address;
            }
        }

        private async Task GetInformation()
        {
            while (true)
            {
                // Get Coin Information
                string coinInformation = ApiClient.HTTP("", "/status", "GET");
                if (coinInformation.StartsWith("{"))
                {
                    JObject JsonParse = JObject.Parse(coinInformation);
                    int networkBlockCount = (int)JsonParse["networkBlockCount"];
                    int hashrate = (int)JsonParse["hashrate"];

                    blockchainHeightValue.Text = String.Format("{0:n0}", networkBlockCount);
                    hashrateValue.Text = String.Format("{0:n0}", hashrate);
                }

                // Get Balance Information
                string balanceInformation = ApiClient.HTTP("", "/balance", "GET");
                if (balanceInformation.StartsWith("{"))
                {
                    JObject JsonParse = JObject.Parse(balanceInformation);
                    int unlocked = (int)JsonParse["unlocked"];
                    int locked = (int)JsonParse["locked"];

                    unlockedValue.Text = String.Format("{0,0:N2}", unlocked / 100.0) + " SPKY";
                    lockedValue.Text = String.Format("{0,0:N2}", locked / 100.0) + " SPKY";
                }
                
                await Task.Delay(3000);
            }
        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void CopyAddress(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(Config.PrimaryAddress);
        }
    }
}
