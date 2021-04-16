using System.Collections.Generic;

namespace FightingSim.Fighters
{
    public class Warrior : BaseFighter
    {
        public Warrior()
        {
            Profession = "Warrior";
            Moves.Add(new KeyValuePair<string, int>("Bash", 8));
            DodgeChance = 10;
            SkillStrength = 1.5;
        }
    }
}
