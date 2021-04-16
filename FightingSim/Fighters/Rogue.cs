using System.Collections.Generic;

namespace FightingSim.Fighters
{
    public class Rogue : BaseFighter
    {
        public Rogue()
        {
            Profession = "Rogue";
            Moves.Add(new KeyValuePair<string, int>("Slice", 5));
            DodgeChance = 25;
        }
    }
}
