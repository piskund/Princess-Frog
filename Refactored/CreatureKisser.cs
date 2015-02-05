﻿namespace PrincessFrog.Refactored1
{
    public class CreatureKisser : IKisser
    {
        private Creature CreatureForKiss { get; set; }

        private bool IsPrincess 
        { 
            get { return this.CreatureForKiss is Princess; } 
        }

        public CreatureKisser()
        {
            this.CreatureForKiss = new Frog();
        }

        public void Kiss()
        {
            if (this.IsPrincess)
            {
                this.CreatureForKiss = new Frog();
            }
            else
            {
                this.CreatureForKiss = new Princess();
            }
        }

        public string GetSomeNoise()
        {
            return this.CreatureForKiss.Talk();
        }
    }
}