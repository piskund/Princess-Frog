using PrincessFrog.Refactored;

namespace PrincessFrog.State
{
    internal class StatefulCreature : Creature
    {
        private readonly string name;
        internal Creature CurrentState { get; set; }

        public string Name
        {
            get { return name; }
        }

        public StatefulCreature(string name, Creature initialState)
        {
            this.name = name;
            this.CurrentState = initialState;
        }

        public override string Talk()
        {
            return string.Format("{0} I am {1}.", this.CurrentState.Talk(), this.Name);
        }
    }
}
