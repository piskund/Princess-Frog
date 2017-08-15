using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.DomainModel.Abstractions;
using PrincessFrogPatterLib.Flyweight;
using PrincessFrogPatterLib.Strategy.Strategies;

namespace PrincessFrogPatterLib.Strategy
{
	public class CreatureKisserStateMachine : ICreatureKisser
	{
		public readonly SpeakingCreature CurrentCreature;

	    public CreatureKisserStateMachine()
	    {
	        CurrentCreature = new SpeakingCreature();
	    }

        public void Kiss()
		{
			if ((CurrentCreature.CreatureType == CreatureType.Frog) || (CurrentCreature.CreatureType == CreatureType.Cat))
			{
				CurrentCreature.CurrentStrategy = new PrincessStrategy();
				//CurrentCreature.CurrentStrategy = StrategyFactory.GetFlyweightState(CreatureType.Princess);
			}
			else if (CurrentCreature.CreatureType == CreatureType.Princess)
			{
				CurrentCreature.CurrentStrategy = new FrogStrategy();
				//CurrentCreature.CurrentStrategy = StrategyFactory.GetFlyweightState(CreatureType.Frog);
			}
		}

		public void Pet()
		{
			if (CurrentCreature.CreatureType == CreatureType.Frog)
			{
				CurrentCreature.CurrentStrategy = new CatStrategy();
				//CurrentCreature.CurrentStrategy = StrategyFactory.GetFlyweightState(CreatureType.Cat);
			}
		}

		public void Kick()
		{
			if (CurrentCreature.CreatureType == CreatureType.Cat)
			{
				CurrentCreature.CurrentStrategy = new FrogStrategy();
				//CurrentCreature.CurrentStrategy = StrategyFactory.GetFlyweightState(CreatureType.Frog);
			}
		}
	}
}