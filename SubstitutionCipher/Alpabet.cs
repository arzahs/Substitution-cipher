using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCipher
{
    class Alpabet
    {
        string alphabet;
        public Alpabet(string alphabet)
        {
            this.alphabet = alphabet;
        }

        public string Replace(string text, int key)
        {
            int position = alphabet.IndexOf(text);
            if (position == -1)
                return "";
            position = (position + key) % alphabet.Length;
            if (position < 0)
                position += alphabet.Length;
            return alphabet.Substring(position, 1);
        }
    }
}
