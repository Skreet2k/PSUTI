using System;

namespace Task3._1
{
    class Program
    {
        public static int Max(int[] array)
        {
            int max = int.MinValue;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] {5,3,4,5,6,7,0};
            Console.WriteLine("Максимальное значение в массиве 5,3,4,5,6,7,0: {0}", Max(array));
            Console.ReadLine();
        }
    }
}
