using FluentAssertions;
using NUnit.Framework;
using PrincessFrogPatterLib.Simple;
//using PrincessFrogPatterLib.NewRequirements;
//using PrincessFrogPatterLib.DomainModel;

namespace PrincessFrog.UnitTests
{
	[TestFixture]
	public class CreatureKisserTest
	{
		[Test]
		public void KissedEvenShouldSayRibbit([Range(0, 8, 2)]int numberOfKiss)
		{
			// Arrange
			var sut = new CreatureKisser();
			for (int i = 0; i < numberOfKiss; i++)
			{
				sut.Kiss();
			}

			// Act
			var result = sut.GetSomeNoise();

			// Assert
			result.Should().Be("Ribbit!");
		}

		[Test]
		public void KissedOddShouldSayHello([Range(1, 9, 2)]int numberOfKiss)
		{
			// Arrange
			var sut = new CreatureKisser();
			for (int i = 0; i < numberOfKiss; i++)
			{
				sut.Kiss();
			}

			// Act
			var result = sut.GetSomeNoise();

			// Assert
			result.Should().Be("Hello!");
		}
	}
}
