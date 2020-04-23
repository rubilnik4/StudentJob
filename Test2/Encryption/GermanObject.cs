using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Encryption
{
    /// <summary>
    /// Зашифрованный объект
    /// </summary>
    public class GermanObject : IFormattable
    {
        public GermanObject(string name, string decription)
        {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            if (String.IsNullOrWhiteSpace(decription)) throw new ArgumentNullException(nameof(decription));

            Name = name;
            Decription = decription;
        }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Decription { get; }

        public string ToString(string format, IFormatProvider formatProvider) => ToString();

        public override string ToString() => Name + "/" + Decription;

        /// <summary>
        /// Проверить данные на соответствие
        /// </summary>       
        public static bool ValidateData(string[] array) => array?.Length == 2 &&
                                                           ValidateData(array[0], array[1]);

        /// <summary>
        /// Проверить данные на соответствие
        /// </summary>       
        public static bool ValidateData(string name, string decription) =>
            !String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(decription);
    }
}
