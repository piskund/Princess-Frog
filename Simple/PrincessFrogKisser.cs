﻿namespace PrincessFrog
{
    public class PrincessFrogKisser : IKisser
    {
        private bool IsPrincess { get; set; }

        public void Kiss()
        {
            this.IsPrincess = !this.IsPrincess;
        }

        public string GetSomeNoise()
        {
            if (this.IsPrincess)
            {
                return "Hello!";
            }
            else
            {
                return "Ribbit!";
            }
        }
    }
}
