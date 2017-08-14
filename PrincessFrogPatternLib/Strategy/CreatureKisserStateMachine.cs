using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.DomainModel.Abstractions;
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
				CurrentCreature.CurrentStrategy = new PrincessStrategy();
			else if (CurrentCreature.CreatureType == CreatureType.Princess)
				CurrentCreature.CurrentStrategy = new FrogStrategy();
		}

		public void Pet()
		{
			if (CurrentCreature.CreatureType == CreatureType.Frog)
				CurrentCreature.CurrentStrategy = new CatStrategy();
		}

		public void Kick()
		{
			if (CurrentCreature.CreatureType == CreatureType.Cat)
				CurrentCreature.CurrentStrategy = new FrogStrategy();
		}
	}
}