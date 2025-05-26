using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    internal static class FileManager
    {
        public static void Save(string message, string path = "./Data/EncryptedMessage.txt")
        {
            File.WriteAllText(path, message);
        }
        public static string Read(string path = "EncryptedMessage.txt")
        {
            string encryptedMessage = File.ReadAllText(path);
            return encryptedMessage;
        }
    }
}
