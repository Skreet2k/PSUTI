using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
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
			byte[] textArray = File.ReadAllBytes(path);
			Console.WriteLine("Какой символ будем заменять?");
			byte changeableCharacter = Convert.ToByte(Console.ReadLine()[0]);
			Console.WriteLine("Чем будем заменять?");
			byte substitutionCharacter = Convert.ToByte(Console.ReadLine()[0]);
			FileStream fs = File.Create(path + "new.txt");
			foreach (var item in textArray)
			{
				if (item == changeableCharacter)
				{
					fs.WriteByte(substitutionCharacter);
					continue;
				}
				fs.WriteByte(item);
			}
			fs.Close();
			Console.WriteLine("Результат записан в {0}new.txt", path);
			Console.Read();
		}
	}
}
