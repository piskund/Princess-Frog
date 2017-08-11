namespace PrincessFrogPatterLib.DomainModel
{
	public interface INoisyCreature
	{
		CreatureType CreatureType { get; }

		string SaySomething();
	}
}