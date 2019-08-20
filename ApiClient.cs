using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Oscillate_Gui_Wallet
{
    class ApiClient
    {
        public static string HTTP(string json, string method, string method_send)
        {
            if (method == "/wallet/open" || method == "/addresses" || method == "/wallet/create" ||
                method == "/node" || method == "/keys" || method == "/status"                                 )
            {
                string url = "http://" + Config.HTTP_Address + ":" + Config.HTTP_Port + method;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = method_send;
                httpWebRequest.Headers["X-API-KEY"] = "kevin11";

                // Send Json request
                if (method_send == "POST")
                {
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
                        // 200 request - success
                        var result = streamReader.ReadToEnd();
                        return result;
                    }
                }
                // Error catching
                catch (WebException wex)
                {
                    if (wex.ToString().Contains("400"))
                    {
                        // Ouput error reason
                        var pageContent = new StreamReader(wex.Response.GetResponseStream())
                                          .ReadToEnd();
                        return pageContent;
                    }
                    else if (wex.ToString().Contains("401"))
                    {
                        return "401";
                    }
                    else if (wex.ToString().Contains("403"))
                    {
                        return "403";
                    }
                    else if (wex.ToString().Contains("500"))
                    {
                        return "500";
                    }
                    else
                    {
                        return wex.ToString();
                    }
                }
            }
            else
            {
                return "0x00";
            }
        }
    }
}
