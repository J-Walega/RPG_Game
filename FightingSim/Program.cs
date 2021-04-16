using System;
using System.Collections.Generic;
using FightingSim.Fighters;
using FightingSim.Utilites;

namespace FightingSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Barbarian barbarian = new Barbarian();


            Console.WriteLine(warrior.Name);
            Console.WriteLine(warrior.HitPoints);
            Console.WriteLine(warrior.Profession);

            foreach(KeyValuePair<string, int> kvp in warrior.Moves)
            {
                Console.WriteLine(kvp.Key);
            }

            Console.WriteLine(barbarian.Name);
            Console.WriteLine(barbarian.HitPoints);
            Console.WriteLine(barbarian.Profession);

            foreach(KeyValuePair<string, int> kvp in barbarian.Moves)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
