using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
	class Program
	{
		public static string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

		public static string Encrypt(string text, int key)
		{
			StringBuilder encryptText = new StringBuilder();
			foreach (var c in text)
			{
				int index;
				if ((index = Letters.IndexOf(c)) != -1)
				{
					encryptText.Append(Letters[(index + key)%Letters.Length]);
				}
				else
				{
					encryptText.Append(c);
				}
			}
			return encryptText.ToString();
		}

		public static string Decrypt(string text, int key)
		{
			return Encrypt(text, Letters.Length - key % Letters.Length);
		}

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
			Console.Write("Введите ключ (целое число больше 0): ");
			int key = int.Parse(Console.ReadLine());
			string text = File.ReadAllText(path);

			text = Encrypt(text, key);
			File.WriteAllText(path, text);
			Console.ReadLine();
		}
	}
}
