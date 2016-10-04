using System;

namespace Task5
{
    class Program
    {
       
        static void Main(string[] args)
        {
            RandomValueArray array = new RandomValueArray(3.5, 5.8, 10);
            Console.WriteLine("Полученный массив с рандомными числами:\n");
            array.ShowArrayToConsole();
            Console.WriteLine("Минимальное значение: {0}", array.GetMinValue());
            Console.WriteLine("Максимальное значение: {0}", array.GetMaxValue());
            Console.WriteLine("Вывод в консоль по индексу:");
            array.ShowByIndexToConsole(5);
            Console.WriteLine("Найдем по значению {0} индекс: {1}", array.GetMinValue(),array.GetIndexByValue(array.GetMinValue()));
            Console.Read();
        }
    }
}
