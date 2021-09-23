using System.Collections.Generic;

namespace BLinkerTest.BLinkerAPI
{
    public class BLConnector
    {
        public BLCredentials Credentials { get; set; }
        public string Method { get; set; }
        public string Parameters { get; set; }

        public BLConnector(string method, string parameters)
        {
            Credentials = new BLCredentials
            {
                Url = "https://api.baselinker.com/connector.php",
                Token = "3002521-3011223-FNGD6QQSUMZWHKF1RKVZ2E52TXNB5Y4GHN21GN32NHKXZI8X6YUGXR9O94L98URY"
            };
            Method = method;
            Parameters = parameters;
        }
    }
}
