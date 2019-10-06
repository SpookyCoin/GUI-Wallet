using System;
using System.Net.Sockets;

namespace SpookyCoin_Gui_Wallet
{
    class Functions
    {
        public static bool PingHost(string ip, int port)
        {
            var client = new TcpClient();
            var result = client.BeginConnect(ip, port, null, null);
            var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(Config.ConnectionTimeout));

            if (success)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
