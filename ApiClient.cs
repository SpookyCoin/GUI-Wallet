using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SpookyCoin_Gui_Wallet
{
    class ApiClient
    {
        public static string HTTP(string json, string method, string method_send)
        {
            if (method == "/wallet/open" || method == "/addresses")
            {
                string url = "http://" + Config.HTTP_Address + ":" + Config.HTTP_Port + method;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = method_send;
                httpWebRequest.Headers["X-API-KEY"] = "kevin11";

                if (method_send == "POST") {
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        streamWriter.Write(json);
                    }
                }

                try
                {
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        return result;
                    }
                }
                // Error catching
                catch (Exception ex)
                {
                    if (ex.ToString().Contains("400"))
                    {
                        return "400";
                    }
                    else if (ex.ToString().Contains("401"))
                    {
                        return "401";
                    }
                    else if (ex.ToString().Contains("403"))
                    {
                        return "403";
                    }
                    else if (ex.ToString().Contains("500"))
                    {
                        return "500";
                    }
                    else
                    {
                        return ex.ToString();
                    }
                }
            } else
            {
                return "error no correct method giving";
            }
        }
    }
}
