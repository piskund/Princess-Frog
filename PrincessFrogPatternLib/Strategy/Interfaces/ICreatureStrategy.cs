using PrincessFrogPatterLib.DomainModel;

namespace PrincessFrogPatterLib.Strategy.Interfaces
{
	public interface ICreatureStrategy
	{
	    CreatureType GetCreatureType();

		string MakeSomeNoise();
	}
}