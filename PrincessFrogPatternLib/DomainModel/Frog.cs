namespace PrincessFrogPatterLib.DomainModel
{
	internal class Frog : INoisyCreature
	{
		public CreatureType CreatureType => CreatureType.Frog;

		public string SaySomething()
		{
			return "Ribbit!";
		}
	}
}