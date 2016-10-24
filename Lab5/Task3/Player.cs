namespace Task3
{
	internal class Player
	{
		public Player(int startHp, string name)
		{
			HealthPoint = startHp;
			Name = name;
		}

		public int HealthPoint { get; private set; }
		public string Name { get; }

		public void Hit()
		{
			HealthPoint--;
		}
	}
}