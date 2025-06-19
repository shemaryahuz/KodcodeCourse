using SOLID.DIP.Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Exercise1.Loggers
{
    internal class FileLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Saves data in a file.");
        }
    }
}
