namespace Task3
{
	internal class FightAction
	{
		public FightAction(BodyPartEnum part, ActionEnum action)
		{
			Part = part;
			Action = action;
		}

		public BodyPartEnum Part { get; set; }
		public ActionEnum Action { get; set; }
	}
}