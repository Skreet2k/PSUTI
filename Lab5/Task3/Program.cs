using System;

namespace Task3
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("Добро пожаловать в игру Street Fighter Console.\nВведите свое имя: ");
			var playerName = Console.ReadLine();
			var game = new Game(2, playerName, "Глупый компьютер");
			var resultAction = new ActionEnum[2];

			while (true)
			{
				Console.Write($"Ваше HP: {game.FirstPlayer.HealthPoint}\nПротивник HP: {game.SecondPlayer.HealthPoint}\n");
				if (resultAction[0] != ActionEnum.Nothink)
				{
					Console.WriteLine("Результат вашего действия: " + resultAction[0]);
				}
				if (resultAction[1] != ActionEnum.Nothink)
				{
					Console.WriteLine("Результат действия бота: " + resultAction[1]);
				}
				Console.WriteLine(
					"Действия:\n1.Атаковать в голову\n2.Атаковать в корпус\n3.Блокировать голову\n4.Блокировать корпус");
				switch (Console.ReadLine())
				{
					case "1":
						resultAction = game.DoAction(new FightAction(BodyPartEnum.Head, ActionEnum.Hit));
						break;
					case "2":
						resultAction = game.DoAction(new FightAction(BodyPartEnum.Body, ActionEnum.Hit));
						break;
					case "3":
						resultAction = game.DoAction(new FightAction(BodyPartEnum.Head, ActionEnum.Block));
						break;
					case "4":
						resultAction = game.DoAction(new FightAction(BodyPartEnum.Body, ActionEnum.Block));
						break;
					default:
						resultAction = game.DoAction(new FightAction(BodyPartEnum.Head, ActionEnum.Nothink));
						break;
				}
				Console.Clear();
				if (game.Winner != null)
				{
					break;
				}
			}
			Console.WriteLine($"Победил {game.Winner}");
			Console.ReadLine();
		}
	}
}