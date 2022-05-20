using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Validation
    {
        public static bool isTurkishLetter(char letter)
        {
            char[] turkishLetter = { 'ç', 'Ç', 'ğ', 'Ğ', 'ı', 'İ', 'ö', 'Ö', 'ş', 'Ş', 'ü', 'Ü' };
            if (Array.Exists(turkishLetter, x => x == letter)) return true;
            return false;
        }

        public static bool isEmpty(params string[] items)
        {
            foreach (string item in items)
            {
                if (item.Length == 0) return true;
            }
            return false;
        }
    }
}