using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestPerfomance
{
	class Program
	{
		public static BigInteger[,] CreateRandomMatrix(int size)
		{
			BigInteger[,] matrix = new BigInteger[size,size];
			Random random = new Random();
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					matrix[i, j] = random.Next(2, 9);
				}
			}
			return matrix;
		}

		public static BigInteger[,] MultiplicationRowsAndColumns(BigInteger[,] matrix)
		{
			BigInteger[,] newMatrix = new BigInteger[matrix.GetLength(0), matrix.GetLength(1)];
			for (int i = 0; i < newMatrix.GetLength(0); i++)
			{
				for (int j = 0; j < newMatrix.GetLength(1); j++)
				{
					newMatrix[i,j] = matrix[i, j]*matrix[j,i];
				}
			}
			return newMatrix;
		}

		static void Main(string[] args)
		{
			BigInteger[,] matrix = CreateRandomMatrix(1000);
			int iteration = 1;
			Stopwatch timer = new Stopwatch();
			while (true)
			{
				timer.Start();
				matrix = MultiplicationRowsAndColumns(matrix);
				timer.Stop();
				Console.WriteLine("Время выполнения {0} итерации: {1} милисекунд", iteration,timer.ElapsedMilliseconds);
				iteration++;
				timer.Reset();
			}

		}
	}
}
