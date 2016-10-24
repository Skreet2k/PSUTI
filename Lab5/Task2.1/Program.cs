using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Task2._1
{
	class Program
	{
		private static Timer timer = new Timer(1000);
		private static int time = 20;
		static void Timer(object sender, ElapsedEventArgs e)
		{
			if (time == 0)
			{
				Console.WriteLine("Время вышло!");

				timer.Stop();
				
			}
			time--;
		}
		static void Main(string[] args)
		{
			timer.Elapsed += Timer;
			var random = new Random();
			Console.WriteLine("Поиграем? Даны два двузначных числа и 20 секунд времени. Найди их сумму и разность! Поехали?");

			while (true)
			{
				Console.ReadLine();
				var firstNum = random.Next(10, 100);
				var secondNum = random.Next(10, 100);
				time = 20;
				timer.Start();
				Console.Write($"{firstNum} + {secondNum} = ");
				var sum = int.Parse(Console.ReadLine());
				if (sum != firstNum + secondNum)
				{
					timer.Stop();
					Console.WriteLine($"А разве правильный ответ не {firstNum + secondNum}?");
					time = 20;
					continue;
				}
				Console.Write($"{firstNum} - {secondNum} = ");
				var diff = int.Parse(Console.ReadLine());
				if (diff != firstNum - secondNum)
				{
					timer.Stop();
					Console.WriteLine($"А разве правильный ответ не {firstNum - secondNum}?");
					time = 20;
					continue;
				}
				Console.WriteLine("Молодец! Так держать!");
			}

		}
	}
}
