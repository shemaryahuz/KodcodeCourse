using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    internal static class Encryptor
    {
        public static string Encrypt(string message, AtbashArrays atbashArrays)
        {
            string encrypted = "";

            int chrIndex;
            foreach (char chr in message)
            {
                if (char.IsUpper(chr))
                {
                    chrIndex = Array.IndexOf(atbashArrays.alphabetAZ, chr);
                    encrypted += atbashArrays.alphabetZA[chrIndex];
                }
                else if (char.IsLower(chr))
                {
                    chrIndex = Array.IndexOf(atbashArrays.alphabetaz, chr);
                    encrypted += atbashArrays.alphabetza[chrIndex];
                }
                else
                {
                    encrypted += chr;
                }
            }
            return encrypted;
        }
    }
}
