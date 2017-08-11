using PrincessFrog.Refactored;

namespace PrincessFrog.FactoryMethod
{
    public class CreatureKisserFM : IKisser
    {
        private bool IsPrincess { get; set; }
        private Creature CreatureForKiss { get; set; }

        public CreatureKisserFM()
        {
            this.CreatureForKiss = this.CreateCreature(this.IsPrincess);
        }

        public void Kiss()
        {
            this.IsPrincess = !this.IsPrincess;
            this.CreatureForKiss = this.CreateCreature(this.IsPrincess);
        }

        public string GetSomeNoise()
        {
            return this.CreatureForKiss.Talk();
        }

        /// <summary>
        /// Factory method, creates creature for kiss
        /// </summary>
        /// <param name="isPrincess">Is existent creature if princess</param>
        /// <returns>newly created creature</returns>
        private Creature CreateCreature(bool isPrincess)
        {
            if (isPrincess)
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
