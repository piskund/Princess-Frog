using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.Strategy.Strategies;

namespace PrincessFrogPatterLib.Strategy
{
	public class CreatureKisserStateMachine
	{
		public readonly Creature CurrentCreature;

	    public CreatureKisserStateMachine()
	    {
	        CurrentCreature = new Creature();
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