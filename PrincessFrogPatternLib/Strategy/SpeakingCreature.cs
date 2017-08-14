using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.DomainModel.Abstractions;
using PrincessFrogPatterLib.DomainModel.Interfaces;
using PrincessFrogPatterLib.Strategy.Interfaces;
using PrincessFrogPatterLib.Strategy.Strategies;

namespace PrincessFrogPatterLib.Strategy
{
    public class SpeakingCreature : BaseEntity, ISpeakingCreature
    {
        public ICreatureStrategy CurrentStrategy { get; set; }

        public SpeakingCreature() : this(new FrogStrategy())
        {
        }

        public SpeakingCreature(ICreatureStrategy strategy)
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