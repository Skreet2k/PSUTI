using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			string path;
			while (true)
			{
				Console.WriteLine(@"Введите путь к текстовому файлу (например: D:\Dev\1.txt)");
				path = Console.ReadLine();
				if (!File.Exists(path))
				{
					Console.WriteLine("Введен неверный путь к файлу!");
					continue;
				}
				break;
			}
			Statistics fileStatistics = new Statistics(path);
			fileStatistics.CalculateSatistics();
			string data = @"Количество символов: " + fileStatistics.NumberOfCharacters + Environment.NewLine +
			              "Количество символов без пробелов: " + fileStatistics.NumberOfCharactersWithoutSpaces +
			              Environment.NewLine +
			              "Количество слов: " + fileStatistics.NumberOfWords + Environment.NewLine +
			              "Количество строк: " + fileStatistics.NumberOfLines + Environment.NewLine +
			              "Количество повторений символов:";
			foreach (var stat in fileStatistics.CharStatistics)
			{
				data += Environment.NewLine + "'" + stat.Key + "': " + stat.Value;
			}
			Console.WriteLine(@"Введите путь к файлу для сохранения (например: D:\Dev\1.txt)");
			path = Console.ReadLine();
			var newFile = File.Create(path);
			newFile.Write(Encoding.UTF8.GetBytes(data), 0, data.Length);
		}
	}
}