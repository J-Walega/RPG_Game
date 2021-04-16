using System.Collections.Generic;

namespace FightingSim.Interface
{
    public interface ICharacter
    {
        string Name { get; set; }
        int HitPoints { get; set; }
        List<KeyValuePair<string, int>> Moves { get; set; }
        string Profession { get; set; }
        int DodgeChance { get; set; }
        double SkillStrength { get; set; }
    }
}
