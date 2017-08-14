using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.DomainModel.Interfaces;
using PrincessFrogPatterLib.Strategy.Interfaces;
using PrincessFrogPatterLib.Strategy.Strategies;

namespace PrincessFrogPatterLib.Strategy
{
    public class Creature : BaseEntity, ISpeaking
    {
        public ICreatureStrategy CurrentStrategy { get; set; }

        public Creature() : this(new FrogStrategy())
        {
        }

        public Creature(ICreatureStrategy strategy)
        {
            CurrentStrategy = strategy;
        }

        public CreatureType CreatureType => CurrentStrategy.GetCreatureType();

        public string SaySomething()
        {
            return CurrentStrategy.MakeSomeNoise();
        }
    }
}