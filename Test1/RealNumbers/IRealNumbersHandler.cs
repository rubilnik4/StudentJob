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
    public interface IRealNumbersHandler
    {
        /// <summary>
        /// Получить среднее геометрическое от положительных чисел массива
        /// </summary>
        double GetAverageGeometricalOfPositivesNumbers();
    }
}
