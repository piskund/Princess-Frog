using PrincessFrogPatterLib.DomainModel.Interfaces;

namespace PrincessFrogPatterLib.DomainModel.Creatures
{
	internal class Frog : ISpeakingCreature
    {
		public CreatureType CreatureType => CreatureType.Frog;

		public string SaySomething()
		{
			return "Ribbit!";
		}
	}
}