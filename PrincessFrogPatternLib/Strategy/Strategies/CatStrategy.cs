using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.Strategy.Interfaces;

namespace PrincessFrogPatterLib.Strategy.Strategies
{
    internal class CatStrategy : ICreatureStrategy
    {
        public CreatureType GetCreatureType()
        {
            return CreatureType.Cat;
        }

        public string MakeSomeNoise()
        {
            return "Meow!";
        }
    }
}