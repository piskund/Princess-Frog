using PrincessFrogPatterLib.DomainModel.Interfaces;

namespace PrincessFrogPatterLib.DomainModel.Creatures
{
    internal class Cat : ISpeakingCreature
    {
        public CreatureType CreatureType => CreatureType.Cat;

        public string SaySomething()
        {
            return "Meow!";
        }
    }
}