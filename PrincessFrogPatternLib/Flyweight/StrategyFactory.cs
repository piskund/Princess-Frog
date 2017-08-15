using System;
using System.Collections.Generic;
using PrincessFrogPatterLib.DomainModel;
using PrincessFrogPatterLib.State.Interfaces;
using PrincessFrogPatterLib.Strategy.Interfaces;
using PrincessFrogPatterLib.Strategy.Strategies;

namespace PrincessFrogPatterLib.Flyweight
{
	public static class StrategyFactory
	{
		private static Dictionary<CreatureType, ICreatureStrategy> Cache { get; } =
			new Dictionary<CreatureType, ICreatureStrategy>();

		public static ICreatureStrategy GetFlyweightState(CreatureType creatureType)
		{
			if (Cache.ContainsKey(creatureType))
				return Cache[creatureType];

			ICreatureStrategy creatureStrategy;
			switch (creatureType)
			{
				case CreatureType.Frog:
					creatureStrategy = new FrogStrategy();
					break;
				case CreatureType.Cat:
					creatureStrategy = new CatStrategy();
					break;
				case CreatureType.Princess:
					creatureStrategy = new PrincessStrategy();
					break;
				default:
					throw new ArgumentException("Please define appropriate state.");
			}
			Cache.Add(creatureType, creatureStrategy);

			return creatureStrategy;
		}
	}
}