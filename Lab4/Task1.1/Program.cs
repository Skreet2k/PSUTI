using System;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                 {1,2,3,4},
                 {1,3,2,1},
                 {-1,-2,-3,-4},
                 {-1,-2,-3,-4},
                 {-1,-3,-2,-1}};            
            int numOfColumn = 0;
            Console.WriteLine("Дана матрица:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,5}",matrix[i,j]);
                }
                Console.WriteLine();
            }
            // Подсчет количества стобцов с четыми элементами
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j,i]%2 == 0)
                    {
                        numOfColumn++;
                        break;
                    }
                }
            }

            Console.WriteLine("Количество столбцов с хотя бы одним четным элементом: {0}", numOfColumn);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int maxValue = Int32.MinValue;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] > maxValue)
                    {
                        maxValue = matrix[i,j];
                    }
                }
                Console.WriteLine("Максимальное значение {0} строки = {1}", i, maxValue);
            }
            Console.Read();
        }
    }
}
