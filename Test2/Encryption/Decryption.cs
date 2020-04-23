using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Encryption
{
    /// <summary>
    /// Дешифровка
    /// </summary>
    public static class Decryption
    {
        /// <summary>
        /// Дешифровать
        /// </summary>       
        public static string Decrypt(string word)
        {
            (string devidedPart, string notDevidedPart) = GetPartsOfDevidedByFour(word);
            string swapDevidedPart = SwapWord(devidedPart);
            return swapDevidedPart + notDevidedPart;
        }

        /// <summary>
        /// Получить части слова кратные и не кратные 4
        /// </summary>
        /// <returns></returns>
        private static (string LeftPart, string RightPart) GetPartsOfDevidedByFour(string word)
        {
            if (word == null || String.IsNullOrWhiteSpace(word)) return (String.Empty, String.Empty);

            int scale = 4;
            decimal devided = word.Length / scale;
            int maxCharIndex = (int)Math.Floor(devided* scale);

            return (word.Substring(0, maxCharIndex), 
                    word.Substring(maxCharIndex, word.Length - maxCharIndex));
        }

        /// <summary>
        /// Инвертировать буквы в слове
        /// </summary>        
        private static string SwapWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
