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
			Context.SetState(new PrincessState(Context));
		}

		public void Pet()
		{
			Context.SetState(new CatState(Context));
		}

		public void Kick()
		{
		}
	}
}