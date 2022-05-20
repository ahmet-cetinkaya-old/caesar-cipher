using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Caesar
    {
        private string message;
        private byte key;

        public Caesar(string message, byte key)
        {
            this.message = message;
            this.key = key;
        }

        public void encrypt()
        {
        }
    }
}