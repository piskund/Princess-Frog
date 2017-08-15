using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.Flyweight;
using PrincessFrogPatterLib.State.Interfaces;
using PrincessFrogPatterLib.Strategy.Strategies;

namespace PrincessFrogPatterLib.State.States
{
	internal class CatState : CatStrategy, ICreatureState
	{
		private IStateContext Context { get; }

		public CatState(IStateContext context)
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
		}

		public void Kick()
		{
		}
	}
}