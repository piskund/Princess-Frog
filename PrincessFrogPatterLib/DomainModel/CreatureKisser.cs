﻿namespace PrincessFrogPatterLib.DomainModel
{
	public class CreatureKisser
	{
		private INoisyCreature CurrentCreature { get; set; }

		public CreatureKisser()
		{
			CurrentCreature = new Frog();
		}

		public void Kiss()
		{
			if ((CurrentCreature.CreatureType == CreatureType.Frog) || (CurrentCreature.CreatureType == CreatureType.Cat))
				CurrentCreature = new Princess();
			else if (CurrentCreature.CreatureType == CreatureType.Princess)
				CurrentCreature = new Frog();
		}

		public void Pet()
		{
			if (CurrentCreature.CreatureType == CreatureType.Frog)
				CurrentCreature = new Cat();
		}

		public void Kick()
		{
			if (CurrentCreature.CreatureType == CreatureType.Cat)
				CurrentCreature = new Frog();
		}

		public string GetSomeNoise()
		{
			return CurrentCreature.SaySomething();
		}
	}
}