using System;
using System.Collections.Generic;
using System.Text;

namespace KoUtilities
{
    public static class KoExtensions
    {
        public static bool IsLetter(this char ch)
        {
            if (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z') return true;
            else return false;
        }

        /// <summary>
        /// A<->Z
        /// </summary>
        public static string AtbashCipher(this string code)
        {
            string code_at = null;
            
            foreach (char cod in code)
            {
                if (!cod.IsLetter()) code_at += cod;
                else
                {
                    char b = char.IsUpper(cod) ? 'A' : 'a';
                    code_at += (char)(25 - cod + 2 * b);
                }
            }              
            return code_at;
        }
        /// <summary>
        /// Caesar Cipher : A->C Z->B for key=2
        /// </summary>
        public static string CaesarCipher(this string code, int key)
        {
            if (key < 0) key = 26 + key;
            string code_cae = null;
            foreach (char cod in code)
            {
                if (!cod.IsLetter()) code_cae += cod;
                else
                {
                    char b = char.IsUpper(cod) ? 'A' : 'a';
                    code_cae += (char)((cod - b + key) % 26 + b);
                }
            }
            return code_cae;
        }
        /// <summary>
        /// Rot-13
        /// </summary>
        public static string CaesarCipher(this string code) => code.CaesarCipher(13);
    }
}
