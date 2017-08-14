using PrincessFrogPatterLib.DomainModel.Abstractions;
using PrincessFrogPatterLib.Strategy.Interfaces;

namespace PrincessFrogPatterLib.State.Interfaces
{
	public interface ICreatureState : ICreatureStrategy, ICreatureKisser
	{
	}
}