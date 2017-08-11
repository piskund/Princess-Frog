using System;

namespace PrincessFrogPatterLib.NewRequirements
{
    public class CreatureKisser
    {
        private CreatureType CurrentCreatureType { get; set; }

        public void Kiss()
        {
			if (CurrentCreatureType == CreatureType.Frog || CurrentCreatureType == CreatureType.Cat)
	        {
		        CurrentCreatureType = CreatureType.Princess;
	        }
	        else if(CurrentCreatureType == CreatureType.Princess)
	        {
		        CurrentCreatureType = CreatureType.Frog;
	        }
        }

	    public void Pet()
	    {
			if (CurrentCreatureType == CreatureType.Frog)
			{
				CurrentCreatureType = CreatureType.Cat;
			}
		}

		public void Kick()
	    {
		    if (CurrentCreatureType == CreatureType.Cat)
		    {
			    CurrentCreatureType = CreatureType.Frog;
		    }
	    }

        public string GetSomeNoise()
        {
	        string noise;

            switch (CurrentCreatureType)
            {
				case CreatureType.Frog:
					noise = "Ribbit!";
					break;
				case CreatureType.Cat:
					noise = "Meow!";
					break;
				case CreatureType.Princess:
					noise = "Hello!";
					break;
				default:
					throw new ArgumentException("Unknown creature");
			}

	        return noise;
        }
    }
}
