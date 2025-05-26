using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    internal class atbashArrays
    {
        public char[] alphabetaz = new char[26];
        public char[] alphabetza = new char[26];
        public char[] alphabetAZ = new char[26];
        public char[] alphabetZA = new char[26];
        public atbashArrays()
        {
            for (int i = 0; i < 26; i++)
            {
                this.alphabetaz[i] = (char)('a' + i);
                this.alphabetza[i] = (char)('z' - i);
                this.alphabetAZ[i] = (char)('A' + i);
                this.alphabetZA[i] = (char)('Z' - i);
            }
        } 
    }
}
