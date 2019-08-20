using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyCoin_Gui_Wallet
{
    class Config
    {
        public static string HTTP_Address = "127.0.0.1";
        public static string HTTP_Port = "8070";
        public static string API_Password = "kevin11";
        public static string[] Nodes = {"127.0.0.1:11421", // Local
                                        "spookypool.nl:11421", // MunchieHigh420 - Neeritter
                                        "whonnock.spookypool.nl:11421", // MunchieHigh420 - Stramproy
                                        "142.93.188.178:11421", // pxckets?
                                        "gabberpool.xyz:11421" //Gabcraftia
                                       };

        // Personal info
        public static string PrimaryAddress = null;
        public static int unlockedBlanace = 0;
        public static int lockedBalance = 0;
    }
}
