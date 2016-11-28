using System;
using System.Linq;

namespace Task3
{
	public enum Distribution
	{
		ПРОП, ПЕРВ, ПОСЛ
	}
	internal class Program
	{
		public static string AmountOfDistribution(Distribution dirstrubutionType, decimal moneyBank, string amountsOfMonney)
		{
			var amountsOfMonneyArray = amountsOfMonney.Split(';').Select(x => decimal.Parse(x)).ToArray();
			switch (dirstrubutionType)
			{
				case Distribution.ПРОП:
					var percentByMonney = moneyBank/amountsOfMonneyArray.Sum();
					for (var i = 0; i < amountsOfMonneyArray.Length; i++)
					{
						amountsOfMonneyArray[i] = Math.Round(amountsOfMonneyArray[i] * percentByMonney, 2, MidpointRounding.AwayFromZero); // округление до 2х знаков
						moneyBank -= amountsOfMonneyArray[i]; // для вычисление оставшейся суммы после округлений					
					}
					amountsOfMonneyArray[amountsOfMonneyArray.Length - 1] += moneyBank; // добавление к последней суммы остатков от округлений;
					break;
				case Distribution.ПЕРВ:
					for (var i = 0; i < amountsOfMonneyArray.Length; i++)
					{
						if (amountsOfMonneyArray[i] < moneyBank) // если денег в банке хватает не меняем выдаваемую сумму
						{
							moneyBank -= amountsOfMonneyArray[i];
							continue;
						}
						amountsOfMonneyArray[i] = moneyBank; // если денег не хватает то отдаем все остатки
						moneyBank = 0;
					}
					break;
				case Distribution.ПОСЛ:
					for (var i = amountsOfMonneyArray.Length - 1; i >= 0; i--)
					{
						if (amountsOfMonneyArray[i] < moneyBank) // если денег в банке хватает не меняем выдаваемую сумму
						{
							moneyBank -= amountsOfMonneyArray[i];
							continue;
						}
						amountsOfMonneyArray[i] = moneyBank; // если денег не хватает то отдаем все остатки
						moneyBank = 0;
					}
					break;

			}
			return string.Join(";", amountsOfMonneyArray);

		}
		private static void Main(string[] args)
		{
			Console.WriteLine(AmountOfDistribution(Distribution.ПОСЛ, 10000, "1000;2000;3000;5000;8000;5000"));
			Console.ReadLine();
		}
	}
}