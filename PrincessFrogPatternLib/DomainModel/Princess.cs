namespace PrincessFrogPatterLib.DomainModel
{
	internal class Princess : INoisyCreature
	{
		public CreatureType CreatureType => CreatureType.Princess;

		public string SaySomething()
		{
			return "Hello!";
		}
	}
}