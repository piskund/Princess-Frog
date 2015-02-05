using PrincessFrog.Refactored1;

namespace PrincessFrog.Factory
{
    public class CommonFrogFactory : ICreatureFactory
    {
        private bool IsPrincess { get; set; }

        public Creature CreateCreature()
        {
            this.IsPrincess = !this.IsPrincess;
            if (this.IsPrincess)
            {
                return new Frog();
            }
            else
            {
                return new Princess();
            }
        }
    }
}
