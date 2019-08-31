using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpookyCoin_Gui_Wallet
{
    public partial class Wallet : Form
    {
        // Set placeholder strings
        public string walletAddressStr;
        public string paymentIdStr;
        public string amountStr;
        public string feeStr;

        public Wallet()
        {
            InitializeComponent();
            
            // Get Primary Address
            string primaryAddress = ApiClient.HTTP("", "/addresses/primary", "GET");
            if (primaryAddress.StartsWith("{"))
            {
                JObject JsonParse = JObject.Parse(primaryAddress);
                string address = (string)JsonParse["address"];

                primaryAddressValue.Text = address;
                Config.PrimaryAddress = address;
            }

            // Add column to transactions
            transactionsGrid.ColumnCount = 6;
            transactionsGrid.Columns[0].Name = "#";
            transactionsGrid.Columns[1].Name = "Date";
            transactionsGrid.Columns[2].Name = "Type";
            transactionsGrid.Columns[3].Name = "Hash";
            transactionsGrid.Columns[4].Name = "Block Height";
            transactionsGrid.Columns[5].Name = "Amount";

            transactionsGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionsGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionsGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Get height, balance, transactions, connected node
            GetInformation();
            connectedNode.Text = "Node: " + Config.Connected_Node;

            // Set Mixin to 1
            mixinLst.SelectedIndex = 0;

            // Set placeholders & colors
            walletAddressStr = "Enter a wallet address (Example: Sp3zsmMPTeN1EnKbFENrjMNaFfEvBd3iPEJnzqaqmKk2BHaKsNdFozFZzBRPBZvMKH2DQ3rZg5onJMwSfBMYLLv6114LE6i45)";
            walletAddressTxt.Text = walletAddressStr;
            walletAddressTxt.ForeColor = Color.Gray;
            paymentIdStr = "Enter a payment ID";
            paymentIdTxt.Text = paymentIdStr;
            paymentIdTxt.ForeColor = Color.Gray;
            amountStr = "1234.00";
            amountTxt.Text = amountStr;
            amountTxt.ForeColor = Color.Gray;
            feeStr = "Min. 1 SPKY";
            feeTxt.Text = feeStr;
            feeTxt.ForeColor = Color.Gray;
        }

        public string[] addRow;
        public void addTransaction(string no, string date, string type, string hash, string blockheight, string amount)
        {
            addRow = new string[] {no, date, type, hash, blockheight, amount};
            // Add top of row
            transactionsGrid.Rows.Insert(0, addRow);

            // Change color for Received or Sent
            Color RedCustom = Color.FromArgb(255, 214, 214);
            Color GreenCustom = Color.FromArgb(214, 255, 214);
            if (type == "Sent")
            {
                transactionsGrid.Rows[0].Cells[2].Style.BackColor = RedCustom;
            } else if(type == "Received")
            {
                transactionsGrid.Rows[0].Cells[2].Style.BackColor = GreenCustom;
            }
        }
        public void emptyTransactions()
        {
            transactionsGrid.Rows.Clear();
        }
        public int currentSelectedRow()
        {
            return transactionsGrid.CurrentCell.RowIndex;
        }
        public void selectCurrentRow(int row)
        {
            transactionsGrid.Rows[row].Selected = true;
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

                    blockchainHeightValue.Text = String.Format("{0:n0}", networkBlockCount).ToString().Replace(".", ",");
                    hashrateValue.Text = String.Format("{0:n0}", hashrate).Replace(".", ",");
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

                    unlockedValue.Text = (unlocked / 100.0).ToString("N", new CultureInfo("en-US")) + " SPKY";
                    lockedValue.Text = (locked / 100.0).ToString("N", new CultureInfo("en-US")) + " SPKY";
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
                        int No = 0;
                        foreach (JObject transactions in resultTransactions["transactions"])
                        {

                            No += 1;
                            string blockHeight = (string)transactions["blockHeight"];
                            int fee = (int)transactions["fee"];
                            string hash = (string)transactions["hash"];
                            int timestamp = (int)transactions["timestamp"];
                            string amount = null;
                            int amountint = 0;

                            foreach (JObject kanker in transactions["transfers"])
                            {
                                amount = ((int)kanker["amount"] / 100.0).ToString("N", new CultureInfo("en-US"));
                                amountint = (int)kanker["amount"];
                            }

                            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                            dtDateTime = dtDateTime.AddSeconds(timestamp).ToLocalTime();
                            string timestampToDateTime = String.Format("{0:dd-MM-yyyy HH:mm}", dtDateTime);
                            
                            string transactionType = null;
                            if (amountint > 0)
                            {
                                transactionType = "Received";
                            }
                            else if (amountint < 0)
                            {
                                transactionType = "Sent";
                            }

                            addTransaction(No.ToString(), timestampToDateTime, transactionType, hash, String.Format("{0:n0}", Convert.ToInt32(blockHeight)).ToString().Replace(".", ","), amount + " SPKY");
                        }
                    }

                    //selectCurrentRow(currentSelectedRow());
                }
                await Task.Delay(3000);
            }
        }

        public static System.Windows.Forms.Timer changeToBlack = new System.Windows.Forms.Timer();
        
        private void CopyAddress(object sender, MouseEventArgs e)
        {
            primaryAddressValue.ForeColor = Color.Green;
            changeToBlack.Tick += new EventHandler(changeToBlack_Tick);
            changeToBlack.Interval = 500;
            changeToBlack.Start();
            Clipboard.SetText(Config.PrimaryAddress);
        }

        public void Exit()
        {
            DialogResult dialogResult = MessageBox.Show("Are u sure you want to exit the SpookyCoin wallet?", "Are u sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ApiClient.HTTP("", "/save", "PUT"); // Logout of wallet in API
                ApiClient.HTTP("", "/wallet", "DELETE"); // Logout of wallet in API
                foreach (var process in Process.GetProcessesByName("wallet-api"))
                {
                    process.Kill();
                }
                Environment.Exit(1);
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void Closed(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are u sure you want to exit the SpookyCoin wallet?", "Are u sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ApiClient.HTTP("", "/save", "PUT"); // Logout of wallet in API
                ApiClient.HTTP("", "/wallet", "DELETE"); // Logout of wallet in API
                foreach (var process in Process.GetProcessesByName("wallet-api"))
                {
                    process.Kill();
                }
                Environment.Exit(1);
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void changeToBlack_Tick(object sender, EventArgs e)
        {
            changeToBlack.Stop();
            primaryAddressValue.ForeColor = Color.Black;
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            About aboutWindow = new About();
            aboutWindow.Show();
        }

        private void placeholderWalletAddressEnter(object sender, EventArgs e)
        {
            if (walletAddressTxt.Text == walletAddressStr)
            {
                walletAddressTxt.Text = "";
                walletAddressTxt.ForeColor = Color.Black;
            }
        }

        private void placeholderWalletAddressLeave(object sender, EventArgs e)
        {
            if (walletAddressTxt.Text == "")
            {
                walletAddressTxt.Text = walletAddressStr;
                walletAddressTxt.ForeColor = Color.Gray;
            }
        }

        private void paymentIdEnter(object sender, EventArgs e)
        {
            if (paymentIdTxt.Text == paymentIdStr)
            {
                paymentIdTxt.Text = "";
                paymentIdTxt.ForeColor = Color.Black;
            }
        }

        private void paymentIdLeave(object sender, EventArgs e)
        {
            if (paymentIdTxt.Text == "")
            {
                paymentIdTxt.Text = paymentIdStr;
                paymentIdTxt.ForeColor = Color.Gray;
            }
        }

        private void amountEnter(object sender, EventArgs e)
        {
            if (amountTxt.Text == amountStr)
            {
                amountTxt.Text = "";
                amountTxt.ForeColor = Color.Black;
            }
        }

        private void amountLeave(object sender, EventArgs e)
        {
            if (amountTxt.Text == "")
            {
                amountTxt.Text = amountStr;
                amountTxt.ForeColor = Color.Gray;
            }
        }

        private void feeEnter(object sender, EventArgs e)
        {
            if (feeTxt.Text == feeStr)
            {
                feeTxt.Text = "";
                feeTxt.ForeColor = Color.Black;
            }
        }

        private void feeLeave(object sender, EventArgs e)
        {
            if (feeTxt.Text == "")
            {
                feeTxt.Text = feeStr;
                feeTxt.ForeColor = Color.Gray;
            }
        }

        public static string DoFormat(double myNumber)
        {
            var s = string.Format("{0:0.00}", myNumber);

            if (s.EndsWith("00"))
            {
                return ((int)myNumber).ToString();
            }
            else
            {
                return s;
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string paymentId;
            int amount;
            int fee;

            if (paymentIdTxt.Text == paymentIdStr)
            { paymentId = ""; }
            else
            { paymentId = paymentIdTxt.Text; }

            if(walletAddressTxt.Text == walletAddressStr)
            {
                MessageBox.Show("Address is empty");
            }

            if (amountTxt.Text == amountStr)
            {
                MessageBox.Show("Amount is not valid");
                amount = 0;
            }
            else
            {
                if (amountTxt.Text.Contains("."))
                {
                    amount = Convert.ToInt32(DoFormat(Convert.ToDouble(amountTxt.Text)).Replace(".", ""));
                }
                else
                {
                    amount = (Convert.ToInt32(amountTxt.Text) * 100);
                }
            }

            if (feeTxt.Text == feeStr)
            { fee = 100; feeTxt.Text = "1"; feeTxt.ForeColor = Color.Black; }
            else
            { fee = (Convert.ToInt32(feeTxt.Text) * 100); }

            string sendTransaction =
            "{" + Environment.NewLine +
            "  \"destinations\": [" + Environment.NewLine +
            "    {" + Environment.NewLine +
            "      \"address\": \"" + walletAddressTxt.Text + "\"," + Environment.NewLine +
            "      \"amount\": " + amount + Environment.NewLine +
            "    }" + Environment.NewLine +
            "  ]," + Environment.NewLine +
            "  \"mixin\": " + mixinLst.Text + "," + Environment.NewLine +
            "  \"fee\": " + fee + "," + Environment.NewLine +
            "  \"sourceAddresses\": [" + Environment.NewLine +
            "    \"" + Config.PrimaryAddress + "\"" + Environment.NewLine +
            "  ]," + Environment.NewLine +
            "  \"paymentID\": \"" + paymentId + "\"," + Environment.NewLine +
            "  \"changeAddress\": \""+ Config.PrimaryAddress + "\"," + Environment.NewLine +
            "  \"unlockTime\": 0" + Environment.NewLine +
            "}";

              MessageBox.Show(ApiClient.HTTP(sendTransaction, "/transactions/send/advanced", "POST"));
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Still in development.");
        }

        private void exportPrivateKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Still in development.");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
