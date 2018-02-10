using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonLoggingTest
{
    class Program
    {
        private static readonly ILog _Log = LogManager.GetLogger<Program>();

        static void Main(string[] args)
        {
            while (true)
            {
                _Log.Debug("Test debug");
                _Log.Error("Test error");
                _Log.Fatal("Test fatal");
                _Log.Info("Test info");
                _Log.Trace("Test trace");
                _Log.Warn("Test warn");

                Thread.Sleep(2000);
            }
        }
    }
}
