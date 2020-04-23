using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.RealNumbers
{
    /// <summary>
    /// Параметры изменения числа
    /// </summary>
    public class NumberChangedEventArgs : EventArgs
    {
        public NumberChangedEventArgs(int index, double value)
        {
            Index = index;
            Value = value;
        }

        /// <summary>
        /// Индекс в массиве
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// Значение в массиве
        /// </summary>
        public double Value { get; }
    }
}
