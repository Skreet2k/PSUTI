using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	public class Statistics
	{
		private readonly string _path;
		public int NumberOfLines { get; set; }
		public int NumberOfWords { get; set; }
		public int NumberOfCharacters { get; set; }
		public int NumberOfCharactersWithoutSpaces { get; set; }
		public Dictionary<char,int> CharStatistics{ get; set; }

		public Statistics(string path)
		{
			_path = path;
			if (!File.Exists(path))
			{
				Console.WriteLine("Введен неверный путь к файлу!");
				throw new FileNotFoundException();
			}
		}

		public void CalculateSatistics()
		{
			string[] fileLines = File.ReadAllLines(_path);
			NumberOfLines = fileLines.Length;
			foreach (var line in fileLines)
			{
				string lineWithoutDuplicateSpaces = RemovingDuplicateSpaces(line);
				NumberOfWords += lineWithoutDuplicateSpaces.Split(' ').Length;
				NumberOfCharacters += line.Length;
				NumberOfCharactersWithoutSpaces += lineWithoutDuplicateSpaces.Replace(" ", "").Length;
			}
			CharStatistics = new Dictionary<char, int>();
			foreach (var line in fileLines)
			{
				foreach (var c in line)
				{
					if (CharStatistics.ContainsKey(c))
					{
						CharStatistics[c] += 1;
					}
					else
					{
						CharStatistics.Add(c,1);
					}
				}
			}
		}

		private string RemovingDuplicateSpaces(string text)
		{
			while (true)
			{
				if (!text.Contains("  "))
				{
					return text;
				}
				text = text.Replace("  ", " ");
			}
		}
	}
}
