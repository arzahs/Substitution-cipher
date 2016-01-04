using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCipher
{
    class Cipher : System.Collections.Generic.List<Alpabet>
    {
        public Cipher()
        {
            this.Add(new Alpabet("abcdefghijklmnopqrstuvwxyz"));
            this.Add(new Alpabet("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
            this.Add(new Alpabet("абвгдеёжзийклмнопрстуфхцчшщъыьэюя"));
            this.Add(new Alpabet("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"));
            this.Add(new Alpabet("0123456789"));
            this.Add(new Alpabet("!\"#$%^&*()+=-_'?.,|/`~№:;@[]{}")); 
        }
        public string encript(string text, int key)
        {
            string rezult = "";
            string tmp = "";
            for (int i = 0; i < text.Length; i++)
            {
                foreach (Alpabet a in this)
                {
                    tmp = a.Replace(text.Substring(i, 1), key);
                    if (tmp != "")
                    {
                        rezult += tmp;
                        break;
                    }
                }
                if (tmp == "")
                {
                    rezult += text.Substring(i, 1);
                }
            }
                return rezult;
        }


    }
}
