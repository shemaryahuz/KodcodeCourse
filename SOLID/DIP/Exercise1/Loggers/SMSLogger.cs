using SOLID.DIP.Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Exercise1.Loggers
{
    internal class SMSLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Send data in SMS.");
        }
    }
}
