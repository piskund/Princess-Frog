using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.Flyweight;
using PrincessFrogPatterLib.State.Interfaces;
using PrincessFrogPatterLib.Strategy.Strategies;

namespace PrincessFrogPatterLib.State.States
{
	internal class FrogState : FrogStrategy, ICreatureState
	{
		private IStateContext Context { get; }

		public FrogState(IStateContext context)
		{
			Context = context;
		}

		public void Kiss()
		{
			//Context.SetState(new PrincessState(Context));
			Context.SetState(StateFactory.GetFlyweightState(CreatureType.Princess, Context));
		}

		public void Pet()
		{
			//Context.SetState(new CatState(Context));
			Context.SetState(StateFactory.GetFlyweightState(CreatureType.Cat, Context));
		}

		public void Kick()
		{
		}
	}
}