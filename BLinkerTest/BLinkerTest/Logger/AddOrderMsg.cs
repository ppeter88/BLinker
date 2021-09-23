using System;

namespace BLinkerTest.Logger
{
    public static class AddOrderMsg
    {
        public static string Get(string result)
        {
            string timestamp = DateTime.Now.ToString();
            string msg = $"[{timestamp}] STATUS ZŁOŻENIA ZAMÓWIENIA: \n {result}";

            return msg;
        }
    }
}
