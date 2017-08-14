namespace PrincessFrogPatterLib.DomainModel.Interfaces
{
    public interface ISpeakingCreature
    {
		CreatureType CreatureType { get; }
		string SaySomething();
	}
}