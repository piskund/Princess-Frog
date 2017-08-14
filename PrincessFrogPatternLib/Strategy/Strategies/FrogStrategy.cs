using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.Strategy.Interfaces;

namespace PrincessFrogPatterLib.Strategy.Strategies
{
	internal class FrogStrategy : ICreatureStrategy
	{
	    public CreatureType GetCreatureType()
	    {
	        return CreatureType.Frog;
        }

	    public string MakeSomeNoise()
	    {
            return "Ribbit!";
        }
	}
}