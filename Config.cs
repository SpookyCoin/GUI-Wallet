using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyCoin_Gui_Wallet
{
    class Config
    {
        public static string HTTP_Address = "127.0.0.1";
        public static string HTTP_Port = "11423";
        public static string API_Password = "API";
        public static string[] Nodes = {"127.0.0.1:11421", // Local
                                        "spookypool.nl:11421", // MunchieHigh420 - Neeritter
                                        "whonnock.spookypool.nl:11421", // MunchieHigh420 - Stramproy
                                        "142.93.188.178:11421", // pxckets?
                                        "gabberpool.xyz:11421" //Gabcraftia
                                       };
        public static string Connected_Node = "";
        public static int ConnectionTimeout = 500;

        // Personal info
        public static string PrimaryAddress = null;
    }
}
