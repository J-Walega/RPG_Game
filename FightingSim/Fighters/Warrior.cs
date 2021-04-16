using System;
using System.Collections.Generic;
using System.Text;
using FightingSim.Interface;
using FightingSim.Utilites;

namespace FightingSim.Fighters
{
    public class Warrior : BaseFighter
    {
        public Warrior()
        {
            Profession = "Warrior";
            Moves.Add(new KeyValuePair<string, int>("Bash", 4));
        }
    }
}
