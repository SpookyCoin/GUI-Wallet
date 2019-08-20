using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscillate_Gui_Wallet
{
    public partial class Wallet : Form
    {
        public Wallet()
        {
            InitializeComponent();
            string response = ApiClient.HTTP("", "/status", "GET");

            if (response.StartsWith("{"))
            {
                JObject JsonParse = JObject.Parse(response);
                int networkBlockCount = (int)JsonParse["networkBlockCount"];
                int hashrate = (int)JsonParse["hashrate"];

                labeblockchainHeight.Text = String.Format("{0:n0}", networkBlockCount);
                labeblockchainHashrate.Text = String.Format("{0:n0}", hashrate);
            }
        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
