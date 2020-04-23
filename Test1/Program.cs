using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Test1.RealNumbers;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] initialiseValues = Enumerable.Range(1, 10).
                                       Select(number => (double)number).
                                       ToArray();
            var realNumbersHandler = new RealNumbersHandler(initialiseValues);

            Console.WriteLine(realNumbersHandler);
            Console.WriteLine("Получить по индексу " + realNumbersHandler.GetByIndex(3));
            Console.WriteLine("Длина массива " + realNumbersHandler.GetArrayLength());

            realNumbersHandler.RealNumbersChangedByIndex += RealNumbersChangedByIndex;
            realNumbersHandler.RealNumbersSumIsTen += RealNumbersSumIsTen;
            for (int i = 0; i < realNumbersHandler.GetArrayLength(); i++)
            {
                realNumbersHandler.SetByIndex(i, 1);
            }

            realNumbersHandler.AddValueToArray(2);
            Console.WriteLine("Добавить число к массиву " + realNumbersHandler);

            IRealNumbersHandler irealNumbersHandler = realNumbersHandler;
            Console.WriteLine("Среднее геометрическое" + irealNumbersHandler.GetAverageGeometricalOfPositivesNumbers());

            Console.ReadLine();
        }

        /// <summary>
        /// Изменение элемента по индексу
        /// </summary>       
        private static void RealNumbersChangedByIndex(object sender, NumberChangedEventArgs e)
        {
            Console.WriteLine($"Элемент {e.Index} изменен на {e.Value}");
        }

        /// <summary>
        /// Равна ли сумма массива десяти
        /// </summary>       
        private static void RealNumbersSumIsTen(object sender, EventArgs e)
        {
            Console.WriteLine($"Сумма равна 10");
        }
    }
}
