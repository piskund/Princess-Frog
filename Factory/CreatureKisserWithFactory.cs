using PrincessFrog.Refactored1;

namespace PrincessFrog.Factory
{
    public class CreatureKisserWithFactory : IKisser
    {
        private readonly ICreatureFactory creatureFactory;
        private Creature CreatureForKiss { get; set; }

        public CreatureKisserWithFactory(ICreatureFactory factory)
        {
            this.creatureFactory = factory;
            this.CreatureForKiss = this.creatureFactory.CreateCreature();
        }

        public void Kiss()
        {
            this.CreatureForKiss = this.creatureFactory.CreateCreature();
        }

        public string GetSomeNoise()
        {
            return this.CreatureForKiss.Talk();
        }
    }
}
