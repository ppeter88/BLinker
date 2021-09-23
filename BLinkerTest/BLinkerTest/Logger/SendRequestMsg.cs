using System;

namespace BLinkerTest.Logger
{
    public static class SendRequestMsg
    {
        public static string Get(string method)
        {
            string timestamp = DateTime.Now.ToString();
            string msg = $"[{timestamp}] Wysyłka komunikatu '{method}'";

            return msg;
        }
    }
}
