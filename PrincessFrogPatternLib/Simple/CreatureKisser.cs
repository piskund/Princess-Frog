namespace PrincessFrogPatterLib.Simple
{
    public class CreatureKisser
    {
        private bool IsPrincess { get; set; }

        public void Kiss()
        {
            IsPrincess = !IsPrincess;
        }

        public string GetSomeNoise()
        {
            if (IsPrincess)
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
