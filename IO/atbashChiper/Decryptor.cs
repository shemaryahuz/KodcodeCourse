using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    internal static class Decryptor
    {
        public static string Decrypt(string encryptedMessage, AtbashArrays atbashArrays)
        {
            string decryptedMessage = "";
            int chrIndex;
            foreach (char chr in encryptedMessage)
            {
                if (char.IsUpper(chr))
                {
                    chrIndex = Array.IndexOf(atbashArrays.alphabetZA, chr);
                    decryptedMessage += atbashArrays.alphabetAZ[chrIndex];
                }
                else if (char.IsLower(chr))
                {
                    chrIndex = Array.IndexOf(atbashArrays.alphabetza, chr);
                    decryptedMessage += atbashArrays.alphabetaz[chrIndex];
                }
                else
                {
                    decryptedMessage += chr;
                }
            }
            return decryptedMessage;
        }
    }
}
