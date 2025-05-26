using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    internal static class Decryptor
    {
        public static string Decrypt(string encryptedMessage)
        {
            string decryptedMessage = "";
            char[] alphabetaz = new char[26];
            char[] alphabetza = new char[26];
            char[] alphabetAZ = new char[26];
            char[] alphabetZA = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabetaz[i] = (char)('a' + i);
                alphabetza[i] = (char)('z' - i);
                alphabetAZ[i] = (char)('A' + i);
                alphabetZA[i] = (char)('Z' - i);
            }
            int chrIndex;
            foreach (char chr in encryptedMessage)
            {
                if (char.IsUpper(chr))
                {
                    chrIndex = Array.IndexOf(alphabetZA, chr);
                    decryptedMessage += alphabetAZ[chrIndex];
                }
                else if (char.IsLower(chr))
                {
                    chrIndex = Array.IndexOf(alphabetza, chr);
                    decryptedMessage += alphabetaz[chrIndex];
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
