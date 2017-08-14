using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.DomainModel.Abstractions;
using PrincessFrogPatterLib.DomainModel.Interfaces;
using PrincessFrogPatterLib.State.Interfaces;
using PrincessFrogPatterLib.State.States;

namespace PrincessFrogPatterLib.State
{
	public class SpeakingCreatureWithState : ISpeakingCreature, IStateContext, ICreatureKisser
	{
		public ICreatureState CurrentState { get; set; }

		public SpeakingCreatureWithState()
		{
			CurrentState = new FrogState(this as IStateContext);
		}

		public CreatureType CreatureType => CurrentState.GetCreatureType();

		public string SaySomething()
		{
			return CurrentState.MakeSomeNoise();
		}

		public void SetState(ICreatureState state)
		{
			CurrentState = state;
		}

		public void Kiss()
		{
			CurrentState.Kiss();
		}

		public void Pet()
		{
			CurrentState.Pet();
		}

		public void Kick()
		{
			CurrentState.Kick();
		}
	}
}