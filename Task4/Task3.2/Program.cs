using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
	class Program
	{
		public static List<string> GetArrayOfSentence(string text)
		{
			List<string> sentenceArray = new List<string>();
			StringBuilder temp = new StringBuilder();
			text = text.Replace("...", ".");
			foreach (var item in text)
			{
				temp.Append(item);
				if (item == '.' || item == '?' || item == '!')
				{
					sentenceArray.Add(temp.ToString().Trim());
					temp.Clear();
				}
			}
			return sentenceArray;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Введите несколько предложений:");
			string text = Console.ReadLine();
			List<string> sentenceArray = GetArrayOfSentence(text);
			Console.WriteLine("Введенные предложения через разделеные строкой");
			foreach (var item in sentenceArray)
			{
				Console.WriteLine(item);
			}
			Console.Read();
		}
	}
}
