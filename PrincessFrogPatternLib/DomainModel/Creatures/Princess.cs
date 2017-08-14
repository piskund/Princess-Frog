using PrincessFrogPatterLib.DomainModel.Interfaces;

namespace PrincessFrogPatterLib.DomainModel.Creatures
{
	internal class Princess : ISpeakingCreature
    {
		public CreatureType CreatureType => CreatureType.Princess;

		public string SaySomething()
		{
			return "Hello!";
		}
	}
}