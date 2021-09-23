using BLinkerTest.Logger;
using System.Net;
using System.Text;

namespace BLinkerTest.BLinkerAPI
{
    public class BLRequestWebClient : IBLRequest
    {
        private ILogger _logger;
        public BLRequestWebClient(ILogger logger)
        {
            _logger = logger;
        }
        public string Send(BLConnector connector)
        {
            string result;
            
            using (var webClient = new WebClient())
            {
                webClient.QueryString.Add("token", connector.Credentials.Token);
                webClient.QueryString.Add("method", connector.Method);
                webClient.QueryString.Add("parameters", connector.Parameters);

                var data = webClient.UploadValues(connector.Credentials.Url, "POST", webClient.QueryString);
                _logger.Log(SendRequestMsg.Get(connector.Method));

                result = UnicodeEncoding.UTF8.GetString(data);
                if (connector.Method == "addOrder")
                {
                    _logger.Log(AddOrderMsg.Get(result));
                }
            }

            return result;
        }
    }
}
