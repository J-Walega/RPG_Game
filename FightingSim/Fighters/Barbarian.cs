using System.Collections.Generic;

namespace FightingSim.Fighters
{
    public class Barbarian : BaseFighter
    {
        public Barbarian()
        {
            Profession = "Barbarian";
            Moves.Add(new KeyValuePair<string, int>("Swing", 10));
            DodgeChance = 5;
            SkillStrength = 2;
        }
    }
}
