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
