using FluentAssertions;
using NUnit.Framework;
using PrincessFrogPatterLib.Strategy;

namespace PrincessFrog.UnitTests
{
	[TestFixture]
	public class StrategyTests
	{
		[Test]
		public void KissedEvenShouldSayRibbit([Range(0, 8, 2)]int numberOfKiss)
		{
			// Arrange
			var sut = new CreatureKisserStateMachine();
			for (int i = 0; i < numberOfKiss; i++)
			{
				sut.Kiss();
			}

			// Act
		    var result = sut.CurrentCreature.SaySomething();

			// Assert
			result.Should().Be("Ribbit!");
		}

		[Test]
		public void KissedOddShouldSayHello([Range(1, 9, 2)]int numberOfKiss)
		{
			// Arrange
			var sut = new CreatureKisserStateMachine();
			for (int i = 0; i < numberOfKiss; i++)
			{
				sut.Kiss();
			}

			// Act
		    var result = sut.CurrentCreature.SaySomething();

			// Assert
			result.Should().Be("Hello!");
		}
	}
}
