using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
{
	class Program
	{
		public static List<string> Method(string text)
		{
			text = text.Trim('.');
			List<string> newWords = new List<string>();
			string[] wordArray = text.Split(' ');
			var temp = new StringBuilder();
			foreach (var item in wordArray)
			{
				temp.Append(item[0]);

				for (int i = 1; i < item.Length; i++)
				{
					if(item[i] != item[0])
						temp.Append(item[i]);
				}

				newWords.Add(temp.ToString());
				temp.Clear();
			}
			newWords.RemoveAll(x => x == newWords.Last());
			return newWords;

		}
		static void Main(string[] args)
		{
			Console.WriteLine("Введите слова через пробел:");
			string text = Console.ReadLine();
			List<string> newText = Method(text);
			Console.WriteLine("Введенные слова после удаления всех равных последнему, с удалением букв равных первой букве слова.");
			foreach (var item in newText)
			{
				Console.WriteLine(item);
			}
			Console.Read();
		}
	}
}
