using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		public static int[] GetTextStatistic(string text)
		{
			char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю' };
			char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ь' };
			text = text.ToLower();
			int numOfvowels = 0;
			int numOfconsonants = 0;

			foreach (var litter in text)
			{
				foreach (var item in consonants)
				{
					if (litter == item)
						numOfconsonants++;
				}
				foreach (var item in vowels)
				{
					if (litter == item)
						numOfvowels++;
				}
			}
			return new int[2] { numOfconsonants, numOfvowels };
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Введите исследуемый на частоту текст:");
			string text = Console.ReadLine();
			int[] statistic = GetTextStatistic(text);
			Console.WriteLine("Количество согласных в тексте: {0}\nгласных: {1}", statistic[0], statistic[1]);
			Console.Read();

		}
	}
}
