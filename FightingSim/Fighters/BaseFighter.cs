using System.Collections.Generic;
using FightingSim.Interface;
using FightingSim.Utilites;

namespace FightingSim.Fighters
{
    public class BaseFighter : ICharacter
    {
        private int _hitpoints = 100;
        private string _name = NameRandomizer.RandomName();
        private List<KeyValuePair<string, int>> _moves = new List<KeyValuePair<string, int>>()
        {
            new KeyValuePair<string, int>("Dodge", 0)
        };

        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }
        public List<KeyValuePair<string, int>> Moves 
        { 
            get => _moves; 
            set => _moves = value; 
        }

        public int HitPoints 
        { 
            get => _hitpoints; 
            set => _hitpoints = value; 
        }

        public string Profession { get; set; }
    }
}
