using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.Flyweight;
using PrincessFrogPatterLib.State.Interfaces;
using PrincessFrogPatterLib.Strategy.Strategies;

namespace PrincessFrogPatterLib.State.States
{
	internal class PrincessState : PrincessStrategy, ICreatureState
	{
		private IStateContext Context { get; }

		public PrincessState(IStateContext context)
		{
			Context = context;
		}

		public void Kiss()
		{
			//Context.SetState(new FrogState(Context));
			Context.SetState(StateFactory.GetFlyweightState(CreatureType.Frog, Context));
		}

		public void Pet()
		{
		}

		public void Kick()
		{
		}
	}
}