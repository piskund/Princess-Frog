namespace PrincessFrogPatterLib.DomainModel
{
	internal class Cat : INoisyCreature
	{
		public CreatureType CreatureType => CreatureType.Cat;

		public string SaySomething()
		{
			return "Meow!";
		}
	}
}