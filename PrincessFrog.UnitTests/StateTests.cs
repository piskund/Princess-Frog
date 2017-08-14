using FluentAssertions;
using NUnit.Framework;
using PrincessFrogPatterLib.State;

namespace PrincessFrog.UnitTests
{
	[TestFixture]
	public class StateTests
	{
		[Test]
		public void KissedEvenShouldSayRibbit([Range(0, 8, 2)]int numberOfKiss)
		{
			// Arrange
			var sut = new SpeakingCreatureWithState();
			for (int i = 0; i < numberOfKiss; i++)
			{
				sut.Kiss();
			}

			// Act
			var result = sut.SaySomething();

			// Assert
			result.Should().Be("Ribbit!");
		}

		[Test]
		public void KissedOddShouldSayHello([Range(1, 9, 2)]int numberOfKiss)
		{
			// Arrange
			var sut = new SpeakingCreatureWithState();
			for (int i = 0; i < numberOfKiss; i++)
			{
				sut.Kiss();
			}

			// Act
			var result = sut.SaySomething();

			// Assert
			result.Should().Be("Hello!");
		}
	}
}