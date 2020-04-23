using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.RealNumbers
{
    /// <summary>
    /// Обработчик массива вещественных чисел
    /// </summary>
    public class RealNumbersHandler : IRealNumbersHandler, IFormattable
    {

        public RealNumbersHandler()
            : this(new double[50])
        { }

        public RealNumbersHandler(double[] realNumbers)
        {
            if (realNumbers == null) throw new ArgumentNullException(nameof(realNumbers));
            if (!ValidateArrayNumberLength(realNumbers)) throw new ArgumentOutOfRangeException(nameof(realNumbers));
            _realNumbers = realNumbers;
        }

        /// <summary>
        /// Массив вещественных чисел
        /// </summary>
        private double[] _realNumbers;

        /// <summary>
        /// Получить элемент массива по индексу
        /// </summary>      
        public double GetByIndex(int index) =>
            (index >= 0 && index < _realNumbers.Length) ?
            _realNumbers[index] :
             throw new ArgumentOutOfRangeException(nameof(index));

        /// <summary>
        /// Получить количество элементов
        /// </summary>      
        public double GetArrayLength() => _realNumbers.Length;

        /// <summary>
        /// Изменить элемент массива по индексу
        /// </summary>      
        public void SetByIndex(int index, double value)
        {
            if (index < 0 || index >= _realNumbers.Length) throw new ArgumentOutOfRangeException(nameof(index));
            _realNumbers[index] = value;
            RealNumbersChangedByIndex?.Invoke(this, new NumberChangedEventArgs(index, value));

            if (IsSumEqualValue(10))
            {
                RealNumbersSumIsTen?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Равна ли сумма массива указанному значению
        /// </summary>      
        public bool IsSumEqualValue(double sumValue) => _realNumbers.Sum() == sumValue;

        /// <summary>
        /// Событие изменения массива по индексу
        /// </summary>
        public event EventHandler<NumberChangedEventArgs> RealNumbersChangedByIndex;

        /// <summary>
        /// Событие равенства массива десяти
        /// </summary>
        public event EventHandler<EventArgs> RealNumbersSumIsTen;

        /// <summary>
        /// Добавить число к каждому элементу массива
        /// </summary>
        public void AddValueToArray(double value)
        {
            _realNumbers = _realNumbers.Select(number => number + value).ToArray();
        }

        /// <summary>
        /// Получить среднее геометрическое от положительных чисел массива
        /// </summary>
        public double GetAverageGeometricalOfPositivesNumbers()
        {
            double multiply = _realNumbers.
                              Where(number => number > 0).
                              Aggregate((first, second) => first * second);
            double degree = 1 / _realNumbers.Length;
            return Math.Pow(multiply, degree);
        }

        /// <summary>
        /// Прверка длины массива
        /// </summary>        
        private static bool ValidateArrayNumberLength(double[] realNumbers) =>
            realNumbers?.Length > 0 && realNumbers?.Length <= 50;

        /// <summary>
        /// ПРеобразование в строку
        /// </summary>       
        public string ToString(string format, IFormatProvider formatProvider) => ToString();

        public override string ToString() => String.Join(";", _realNumbers);
    }
}
