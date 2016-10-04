using System;

namespace Task4._1
{
    class Program
    {
        /// <summary>
        /// Создание массива целых чисел с помощью консоли
        /// </summary>
        public static int[] CreateArrayFromConsole()
        {
            Console.Write("Введите размер массива:");
            int size = GetIntFromConsole();
            if (size <= 0)
            {
                return CreateArrayFromConsole();                
            }
            int[] array = new int[size];
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("array[{0}] = ", index);
                array[index] = GetIntFromConsole();
            }
            return array;
        }
        /// <summary>
        /// Количество нечетных чисел массива
        /// </summary>
        /// <param name="array">массив целых чисел</param>
        public static int NumberOfEvens(int[] array)
        {
            int numberOfEvens = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index]%2 != 0)
                {
                    numberOfEvens++;
                }
            }
            return numberOfEvens;
        }

        /// <summary>
        /// Вывести массив в консоль.
        /// </summary>
        public static void ShowArrayToConsole(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine("array[{0}] = {1}", index, array[index]);
            }
        }
        /// <summary>
        /// Получить целые числа из консоли с обработкой ошибок
        /// </summary>
        private static int GetIntFromConsole()
        {
            int size;
            if (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Неверный ввод!");
                return GetIntFromConsole();
            }
            return size;
        }
        static void Main(string[] args)
        {
            int[] array = CreateArrayFromConsole();
            Console.WriteLine("Полученный массив целых чисел:");
            ShowArrayToConsole(array);
            Console.WriteLine("Количество нечетных чисел: {0}", NumberOfEvens(array));
            Console.ReadLine();
        }
    }
}
