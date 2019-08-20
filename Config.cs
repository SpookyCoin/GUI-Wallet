using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscillate_Gui_Wallet
{
    class Config
    {
        public static string HTTP_Address = "127.0.0.1";
        public static string HTTP_Port = "8070";
        public static string API_Password = "kevin11";
        public static string[] Nodes = {"127.0.0.1:11246", // Local
                                        "134.209.75.124:11246", // Node 1
                                        "134.209.208.103:11245:11246", // dddrgonzoo's USA node
                                        "45.32.240.41:11246" // dddrgonzoo's AUS node
                                       };
    }
}
