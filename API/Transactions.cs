using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyCoin_Gui_Wallet.API
{
    class Transactions
    {
        public string hash { get; internal set; }
        public int fee { get; internal set; }
        public int blockHeight { get; internal set; }
        public int timestamp { get; internal set; }
    }
}
