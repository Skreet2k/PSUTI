using System;


namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите размерность квадатной матрицы: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Попробуйте еще раз: ");
            }
            Console.WriteLine("Сформирована матрица:");
            int[,] matrix = new int[n,n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = n - i - 1; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i+j+1)/(n+1)+1;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
