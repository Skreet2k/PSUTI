using System;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNegativeNumber = 0;
            while (true)
            {
                int number;
                Console.Write("Введите целое число: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number == 0)
                    {
                        break;
                    }
                    if (number < 0)
                    {
                        numOfNegativeNumber++;
                    }
                }
            }
            Console.WriteLine("Количество отрицательных целых чисел: {0}", numOfNegativeNumber);
            Console.ReadLine();
        }
    }
}
