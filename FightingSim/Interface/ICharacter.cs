using System;
using System.Collections.Generic;
using System.Text;

namespace FightingSim.Interface
{
    public interface ICharacter
    {
        string Name { get; set; }
        int HitPoints { get; set; }
        List<KeyValuePair<string, int>> Moves { get; set; }
        string Profession { get; set; }
    }
}
