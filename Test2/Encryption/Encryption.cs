using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Encryption
{
    /// <summary>
    /// Шифрованное послание
    /// </summary>
    public class EncryptionMessage
    {
        public EncryptionMessage(IEnumerable<string> encryptionLines)
        {
            EncryptionLines = encryptionLines ?? new List<string>();
        }

        /// <summary>
        /// Зашифрованное послание
        /// </summary>
        public IEnumerable<string> EncryptionLines { get; }

        /// <summary>
        /// Расшифрованное послание
        /// </summary>
        public IEnumerable<string> DecryptionLines => Decrypt();

        /// <summary>
        /// Расшировать послание
        /// </summary>       
        private IEnumerable<string> Decrypt() => EncryptionLines.
                                                 Select(SeparateBySlash).
                                                 Where(GermanObject.ValidateData).
                                                 Select(separatedLine => new GermanObject(Decryption.Decrypt(separatedLine[0]),
                                                                                          Decryption.Decrypt(separatedLine[1])).
                                                                         ToString());


        /// <summary>
        /// Разделить на слова по слэшу
        /// </summary>       
        private string[] SeparateBySlash(string encryptedLine) => encryptedLine?.Split('/');

    }
}
