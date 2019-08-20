﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

                    unlockedValue.Text = String.Format("{0:n0}", unlocked);
                    lockedValue.Text = String.Format("{0:n0}", locked);
                }

                await Task.Delay(3000);
            }
        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
