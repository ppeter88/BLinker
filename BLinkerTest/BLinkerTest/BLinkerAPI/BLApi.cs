using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinkerTest.BLinkerAPI
{
    public class BLApi
    {
        private IBLRequest _BLRequest;

        public BLApi(IBLRequest bLRequest)
        {
            _BLRequest = bLRequest;
        }
        public string SendRequest(BLConnector connector)
        {
            return _BLRequest.Send(connector);
        }
    }
}
