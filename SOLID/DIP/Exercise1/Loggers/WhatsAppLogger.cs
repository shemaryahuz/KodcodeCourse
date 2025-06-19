using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.DIP.Exercise1.Interfaces;

namespace SOLID.DIP.Exercise1.Loggers
{
    internal class WhatsAppLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Send data in WhatsApp.");
        }
    }
}
