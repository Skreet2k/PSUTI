using System;

namespace Task3
{
	internal class Game
	{
		private readonly int _startHp;

		public Game(int startHp, string firstPlayerName, string secondPlayerName)
		{
			if (startHp < 0)
			{
				startHp = 10;
			}
			_startHp = startHp;
			FirstPlayer = new Player(_startHp, firstPlayerName);
			SecondPlayer = new Player(_startHp, secondPlayerName);
		}

		public Player FirstPlayer { get; }
		public Player SecondPlayer { get; }

		public string Winner { get; private set; }

		public ActionEnum[] DoAction(FightAction action)
		{
			var resultActions = new ActionEnum[2];
			var botAction = DoRandomBotAction();
			resultActions[0] = GameProcess(action, botAction);
			resultActions[1] = GameProcess(botAction, action);
			if (resultActions[0] == ActionEnum.Hit)
			{
				SecondPlayer.Hit();
			}
			if (resultActions[1] == ActionEnum.Hit)
			{
				FirstPlayer.Hit();
			}
			CheckWinner();
			return resultActions;
		}

		private FightAction DoRandomBotAction()
		{
			var random = new Random();
			var asd = random.Next(0, 2);
			var asd1 = random.Next(1, 3);
			return new FightAction((BodyPartEnum) asd, (ActionEnum) asd1);
		}


		private ActionEnum GameProcess(FightAction firstAction, FightAction secondAction)
		{
			switch (firstAction.Action)
			{
				case ActionEnum.Block:
					if (secondAction.Action == ActionEnum.Hit)
					{
						if (secondAction.Part == firstAction.Part)
						{
							return ActionEnum.Block;
						}
					}
					return ActionEnum.Nothink;

				case ActionEnum.Hit:
					if (secondAction.Action == ActionEnum.Block)
					{
						if (secondAction.Part == firstAction.Part)
						{
							return ActionEnum.Nothink;
						}
					}
					return ActionEnum.Hit;

				default:
					return ActionEnum.Nothink;
			}
		}

		private void CheckWinner()
		{
			if (FirstPlayer.HealthPoint == 0 && SecondPlayer.HealthPoint > 0)
				Winner = SecondPlayer.Name;
			if (SecondPlayer.HealthPoint == 0 && FirstPlayer.HealthPoint > 0)
				Winner = FirstPlayer.Name;
			if (FirstPlayer.HealthPoint == 0 && SecondPlayer.HealthPoint == 0)
			{
				Winner = "Дружба";
			}
		}
	}
}