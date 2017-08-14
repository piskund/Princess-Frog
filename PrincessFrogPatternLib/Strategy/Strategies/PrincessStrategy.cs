using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.Strategy.Interfaces;

namespace PrincessFrogPatterLib.Strategy.Strategies
{
    internal class PrincessStrategy : ICreatureStrategy
    {
        public CreatureType GetCreatureType()
        {
            return CreatureType.Princess;
        }

        public string MakeSomeNoise()
        {
            return "Hello!";
        }
    }
}