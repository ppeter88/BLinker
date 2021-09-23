using System;
using System.Threading;

namespace BLinkerTest.Logger
{
    public class LoggerCw : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(1000);
        }
    }
}
