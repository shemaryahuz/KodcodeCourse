using SOLID.DIP.Exercise1.Interfaces;
using SOLID.DIP.Exercise1.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Exercise1.Controller
{
    internal class MissionController
    {
        public MissionController()
        {
            Loggers = new List<ILogger>
            {
                new FileLogger(),
                new SMSLogger(),
                new WhatsAppLogger()
            };
        }
        public List<ILogger> Loggers;
        public void RunLoggers()
        {
            foreach (ILogger logger in Loggers)
            {
                logger.Log();
            }
        }
    }
}
