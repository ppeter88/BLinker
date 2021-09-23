using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLinkerTest.BLinkerAPI
{
    public class BLRequestWebClient : IBLRequest
    {
        public string Send(BLConnector connector)
        {
            string result;
            
            using (var webClient = new WebClient())
            {
                webClient.QueryString.Add("token", connector.Credentials.Token);
                webClient.QueryString.Add("method", connector.Method);
                webClient.QueryString.Add("parameters", connector.Parameters);

                var data = webClient.UploadValues(connector.Credentials.Url, "POST", webClient.QueryString);
                result = UnicodeEncoding.UTF8.GetString(data);
            }

            return result;
        }
    }
}
