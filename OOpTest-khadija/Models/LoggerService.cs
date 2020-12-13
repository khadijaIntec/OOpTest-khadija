using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpTest_khadija.Models
{
  public  class LoggerService
    {
        private static LogMessage[] logs;
        public static LogMessage[] Logs
        {
            get { return logs; }
            set { logs = value; }
        }
        static LoggerService()
        {
            Logs = new LogMessage[0];
        }
        public static void AddLogMessage(LogMessage message)
        {
            Array.Resize(ref logs, Logs.Length + 1);
            Logs[Logs.Length - 1] = message;
        }
    }
}

    