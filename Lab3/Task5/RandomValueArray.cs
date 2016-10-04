using System;

namespace Task5
{
    class RandomValueArray
    {
        public double[] Array { get; set; }
        /// <summary>
        /// Генерирует рандомно заполненный массив
        /// </summary>
        /// <param name="minValue">минимальное значение</param>
        /// <param name="maxValue">максимальное значение</param>
        /// <param name="arrayCount">размер массива</param>
        /// <returns>заполненный массив</returns>
        public  RandomValueArray(double minValue, double maxValue, int arrayCount)
        {
            if (arrayCount <= 0)
            {
                Array = new double[] {};
            }
            else
            {
                Array = new double[arrayCount];
                Random rnd = new Random();
                for (int index = 0; index < arrayCount; index++)
                {
                    Array[index] = rnd.NextDouble()*(maxValue - minValue) + minValue;
                }
            }
        }
        /// <summary>
        /// Вывести массив в консоль.
        /// </summary>
        public void ShowArrayToConsole()
        {
            for (int index = 0; index < Array.Length; index++)
            {
                Console.WriteLine("array[{0}] = {1}", index, Array[index]);
            }
        }
        /// <summary>
        /// Максимальное значение
        /// </summary>
        /// <returns></returns>
        public  double GetMaxValue()
        {
            double value = double.MinValue;
            for (int index = 0; index < Array.Length; index++)
            {
                if (Array[index] > value)
                {
                    value = Array[index];
                }
            }
            return value;
        }
        /// <summary>
        /// Минимальное значение
        /// </summary>
        /// <returns></returns>
        public  double GetMinValue()
        {
            double value = double.MaxValue;
            for (int index = 0; index < Array.Length; index++)
            {
                if (Array[index] < value)
                {
                    value = Array[index];
                }
            }
            return value;
        }
        /// <summary>
        /// Вывод значения в консоль по индексу
        /// </summary>
        /// <param name="index">индекс ячейки массива</param>
        public void ShowByIndexToConsole(int index)
        {
            if (index < 0 || Array.Length <= index)
            {
                Console.WriteLine("Данный массив не содержит [{0}] элемента", index);
            }
            else
            {
                Console.WriteLine("array[{0}] = {1}",index, Array[index]);
            }
        }
        /// <summary>
        /// Получить первый найденный индекс ячейки содержащей значение value
        /// </summary>
        /// <param name="value">значение</param>
        /// <returns>индекс ячейки массива, если не найден возвращает -1</returns>
        public int GetIndexByValue(double value)
        {
            for (int index = 0; index < Array.Length; index++)
            {
                if (Array[index] == value)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
