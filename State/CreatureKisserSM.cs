namespace PrincessFrog.State
{
    public class CreatureKisserSM : IKisser
    {
        public void Kiss()
        {
            VasilisaStateMachine.Instance.MoveToTheNextState();
        }

        public string GetSomeNoise()
        {
            return VasilisaStateMachine.Instance.GetState().Talk();
        }
    }
}
