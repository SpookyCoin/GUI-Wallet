using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SpookyCoin_Gui_Wallet
{
    public partial class Wallet : Form
    {
        public Wallet()
        {
            InitializeComponent();

            // Get Primary Address
            string primaryAddress = ApiClient.HTTP("", "/addresses/primary", "GET");
            if (primaryAddress.StartsWith("{"))
            {
                JObject JsonParse = JObject.Parse(primaryAddress);
                string address = (string)JsonParse["address"];

                primaryAddressValue.Text = "Address: " + address;
                Config.PrimaryAddress = address;
            }

            // Add column to transactions
            transactionsGrid.ColumnCount = 4;
            transactionsGrid.Columns[0].Name = "Date";
            transactionsGrid.Columns[1].Name = "Type";
            transactionsGrid.Columns[2].Name = "Address";
            transactionsGrid.Columns[3].Name = "Amount";
            transactionsGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Get height, balance, transactions
            GetInformation();
            
        }

        public string[] addRow;
        public void addTransaction(string date, string type, string address, string amount)
        {
            addRow = new string[] {date, type, address, amount};
            transactionsGrid.Rows.Add(addRow);
        }
        public void emptyTransactions()
        {
            transactionsGrid.Rows.Clear();
        }
        
        public async Task GetInformation()
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

                // Get Transactions
                string transactionsInformation = ApiClient.HTTP("", "/transactions", "GET");
                if (transactionsInformation.StartsWith("{"))
                {
                    emptyTransactions();

                    string jsonTransactions = "["+transactionsInformation.Replace("\n", "")+"]";
                    JArray objectTransactions = Newtonsoft.Json.JsonConvert.DeserializeObject<JArray>(jsonTransactions);
                    foreach (var resultTransactions in objectTransactions)
                    {
                        foreach (JObject transactions in resultTransactions["transactions"])
                        {
                            string blockHeight = (string)transactions["blockHeight"];
                            int fee = (int)transactions["fee"];
                            string hash = (string)transactions["hash"];
                            int timestamp = (int)transactions["timestamp"];
                            int amount = 0;

                            foreach (JObject kanker in transactions["transfers"])
                            {
                                amount = (int)kanker["amount"];
                            }

                            addTransaction(timestamp.ToString(), "Receive", "-", amount.ToString() + " SPKY");
                        }
                    }
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
