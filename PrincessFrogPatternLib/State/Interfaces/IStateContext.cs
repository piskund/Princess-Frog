using PrincessFrogPatterLib.Strategy.Interfaces;

namespace PrincessFrogPatterLib.State.Interfaces
{
	public interface IStateContext
	{
		void SetState(ICreatureState state);
	}
}