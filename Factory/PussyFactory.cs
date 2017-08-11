using PrincessFrog.Refactored;

namespace PrincessFrog.Factory
{
    public class PussyFactory : ICreatureFactory
    {
        private int Counter { get; set; }

        public Creature CreateCreature()
        {
            Creature newCreature;

            switch (this.Counter)
            {
                case 0:
                    newCreature = new Frog();
                    break;
                case 1:
                    newCreature = new Princess();
                    break;
                default:
                    newCreature = new Cat();
                    break;
            }

            this.Counter++;
            return newCreature;
        }
    }
}
