using System;
using System.Collections.Generic;
using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.State.Interfaces;
using PrincessFrogPatterLib.State.States;

namespace PrincessFrogPatterLib.Flyweight
{
	public static class StateFactory
	{
		private static Dictionary<CreatureType, ICreatureState> Cache { get; } =
			new Dictionary<CreatureType, ICreatureState>();

		public static ICreatureState GetFlyweightState(CreatureType creatureType, IStateContext context)
		{
			if (Cache.ContainsKey(creatureType))
				return Cache[creatureType];

			ICreatureState state;
			switch (creatureType)
			{
				case CreatureType.Frog:
					state = new FrogState(context);
					break;
				case CreatureType.Cat:
					state = new CatState(context);
					break;
				case CreatureType.Princess:
					state = new PrincessState(context);
					break;
				default:
					throw new ArgumentException("Please define appropriate state.");
			}
			Cache.Add(creatureType, state);

			return state;
		}
	}
}