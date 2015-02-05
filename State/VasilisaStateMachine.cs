using PrincessFrog.Refactored1;

namespace PrincessFrog.State
{
    public class VasilisaStateMachine
    {
        private static readonly Creature FrogState = new Frog();
        private static readonly Creature PrincessState = new Princess();
        private static readonly VasilisaStateMachine instance = new VasilisaStateMachine();

        public static VasilisaStateMachine Instance
        {
            get { return VasilisaStateMachine.instance; }
        } 

        private StatefulCreature NamedCreature { get; set; }

        private VasilisaStateMachine()
        {
            this.NamedCreature = new StatefulCreature("Vasilisa", FrogState);
        }

        public Creature GetState()
        {
            return this.NamedCreature;
        }

        public void MoveToTheNextState()
        {
            if (this.NamedCreature.CurrentState is Frog)
            {
                this.NamedCreature.CurrentState = PrincessState;
            }
            else
            {
                this.NamedCreature.CurrentState = FrogState;
            }
        }
    }
}
